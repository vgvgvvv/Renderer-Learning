#pragma once
#include <cstdint>
#include "ClassContext.h"

template<class T>
struct TypeTag
{
    typedef T value;
};
template<class T>
struct ClassTag
{
    typedef T value;
};

namespace ClassDetail
{
    /* ========================================================================= */
	/* Hash                                                                      */
	/* ========================================================================= */
    static constexpr uint64_t kFNV1aValue = 0xcbf29ce484222325;
    static constexpr uint64_t kFNV1aPrime = 0x100000001b3;

    inline constexpr uint64_t
        Hash(char const* const str, uint64_t const value = kFNV1aValue) noexcept
    {
        return (str[0] == '\0')
            ? value
            : Hash(&str[1], (value ^ uint64_t(str[0])) * kFNV1aPrime);
    }
}


class Type;

struct TemplateArgument
{
    enum class Tag {
        Type,
        Number,
    };

    Tag tag;
    union {
        Type const* type;
        uint64_t number;
    };
};

enum class ClassFlag
{
	None = 0,
	Abstruct = 1 << 2
};

class Type
{

public:
    Type(
        int size,
        char const* name) noexcept
        : m_size(size)
        , m_hash(ClassDetail::Hash(name))
        , m_name(name)
    {
        
    }

    /* --------------------------------------------------------------------- */
    /* Identifier                                                            */
    /* --------------------------------------------------------------------- */
    virtual bool IsClass() const noexcept { return false; };

    /* --------------------------------------------------------------------- */
    /* Access                                                                */
    /* --------------------------------------------------------------------- */
    uint64_t
        Size() const noexcept
    {
        return m_size;
    }

    uint64_t
        Hash() const noexcept
    {
        return m_hash;
    }

    char const*
        Name() const noexcept
    {
        return m_name;
    }

    /* --------------------------------------------------------------------- */
    /* Operator                                                              */
    /* --------------------------------------------------------------------- */
    bool
        operator==(Type const& other) const noexcept
    {
        return m_hash == other.m_hash;
    }

    bool
        operator!=(Type const& other) const noexcept
    {
        return !(*this == other);
    }


protected:
    uint64_t m_size;
    uint64_t m_hash;
    char const* m_name;
};

class Class : public Type
{

public:
    Class(
        int size,
        const Class* baseClass,
        char const* name, 
        ClassFlag flag = ClassFlag::None) noexcept
        : Type(size, name)
        , m_baseClass(baseClass)
		, classFlag(flag)
    {
        ClassContext::Get().RegisterMap(name, this);
        defined = true;
    }

	template<class Lambda>
    Class(
        int size,
        const Class* baseClass,
        char const* name,
        ClassFlag flag, 
        Lambda&& ctor) noexcept
        : Type(size, name)
        , m_baseClass(baseClass)
        , classFlag(flag)
    {
        ctor(this);
        ClassContext::Get().RegisterMap(name, this);
        defined = true;
    }

    /* --------------------------------------------------------------------- */
    /* Identifier                                                            */
    /* --------------------------------------------------------------------- */
    virtual bool IsClass() const noexcept override { return true; };


    /* --------------------------------------------------------------------- */
    /* Access                                                                */
    /* --------------------------------------------------------------------- */
    Class const*
        BaseClass() const noexcept
    {
        return m_baseClass;
    }

	bool IsA(const Class* targetClass) const
    {
        const auto baseClass = BaseClass();
        if (baseClass == targetClass)
        {
            return true;
        }
        if (baseClass == nullptr)
        {
            return false;
        }
        return baseClass->IsA(targetClass);
    }

	bool HasFlag(ClassFlag flag) const
    {
        return (int)classFlag & (int)flag;
    }

    std::shared_ptr<void> Create() const
    {
        return ctor();
    }

	template<class T>
    std::shared_ptr<T> Create() const
    {
        return std::static_pointer_cast<T>(ctor());
    }

public:

	void SetCtor(std::function<std::shared_ptr<void>()>&& newCtor)
	{
        ctor = newCtor;
	}

protected:
    const Class* m_baseClass;
    ClassFlag classFlag;
    std::function<std::shared_ptr<void>()> ctor;
    // 已经定义完毕 不允许再次修改
	bool defined;
};


/* ========================================================================= */
/* Templates                                                                 */
/* ========================================================================= */

class ClassTemplate : public Class
{
public:
    ClassTemplate(
        int size,
        const Class* baseClass,
        char const* name,
        ClassFlag flag,
        TemplateArgument* templateArgs,
        TemplateArgument* templateArgsEnd) noexcept
        : Class(
            size,
            baseClass,
            name,
            flag)
        , m_templateArgs(templateArgs)
        , m_templateArgsEnd(templateArgsEnd)
    {}

    template<class Lambda>
    ClassTemplate(
        int size,
        const Class* baseClass,
        char const* name,
        ClassFlag flag,
        Lambda&& ctor,
        TemplateArgument* templateArgs,
        TemplateArgument* templateArgsEnd) noexcept
        : Class(
            size,
            baseClass,
            name,
            flag,
            ctor)
        , m_templateArgs(templateArgs)
        , m_templateArgsEnd(templateArgsEnd)
    {}

public:
    TemplateArgument* m_templateArgs;
    TemplateArgument* m_templateArgsEnd;
};
