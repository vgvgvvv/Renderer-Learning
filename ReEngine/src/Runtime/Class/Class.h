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
        ClassContext::Get().RegisterMap(name, this);
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


public:
    uint64_t m_size;
    uint64_t m_hash;
    char const* m_name;
};

class Class : public Type
{

public:
    Class(
        int size,
        Class* baseClass,
        char const* name) noexcept
        : Type(size, name)
        , m_baseClass(baseClass)
    {
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

public:
    Class* m_baseClass;
};


/* ========================================================================= */
/* Templates                                                                 */
/* ========================================================================= */

class ClassTemplate : public Class
{
public:
    ClassTemplate(
        int size,
        Class* baseClass,
        char const* name,
        TemplateArgument* templateArgs,
        TemplateArgument* templateArgsEnd) noexcept
        : Class(
            size,
            baseClass,
            name)
        , m_templateArgs(templateArgs)
        , m_templateArgsEnd(templateArgsEnd)
    {}

public:
    TemplateArgument* m_templateArgs;
    TemplateArgument* m_templateArgsEnd;
};
