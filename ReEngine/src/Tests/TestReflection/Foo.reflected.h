/* this file is auto-generated. do not edit! */
#pragma once
#include "re_reflect.hxx"
namespace re_reflect
{

template<> struct IsSerializable<Foo> { static constexpr bool value = false; };
template<> struct HasBeforeSerialize<Foo> { static constexpr bool value = false; };
template<> struct HasAfterSerialize<Foo> { static constexpr bool value = false; };
template<> struct HasCustomSerialize<Foo> { static constexpr bool value = false; };
template<> struct HasCustomDump<Foo> { static constexpr bool value = false; };
namespace detail
{
template<>
Class const *
GetClassImpl(ClassTag<Foo>) noexcept
{
static detail::ClassStorage<Foo, 2, 0> reflected([](auto self) {

/* Field 1 */
self->fields[0].m_type = GetType<int>();
self->fields[0].m_flags = Field::kFlagsNull;
self->fields[0].m_serializedWidth = sizeof(int) * 8;
self->fields[0].m_offset = offsetof(Foo, a);
self->fields[0].m_qualifier = Qualifier(0, 0, 0, 0, 0, 0);
self->fields[0].m_name = "a";

/* Field 2 */
self->fields[1].m_type = GetType<std::basic_string<char>>();
self->fields[1].m_flags = Field::kFlagsNull;
self->fields[1].m_serializedWidth = sizeof(std::basic_string<char>) * 8;
self->fields[1].m_offset = offsetof(Foo, str);
self->fields[1].m_qualifier = Qualifier(0, 0, 0, 0, 0, 0);
self->fields[1].m_name = "str";
});
static Class cache(
sizeof(Foo),
Hash("Foo"),
nullptr/*TODO: baseclass*/,
reflected.fields,
reflected.fields + reflected.numFields,
reflected.functions,
reflected.functions + reflected.numFunctions,
"Foo",
Class::kFlagsNull);
return &cache;
}

template<>
Type const *
GetTypeImpl(TypeTag<Foo>) noexcept
{
return GetClass<Foo>();
}
} /* namespace detail */
} /* namespace re_reflect */

