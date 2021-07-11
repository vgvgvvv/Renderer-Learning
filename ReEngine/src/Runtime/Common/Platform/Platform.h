#pragma once

#include "PlatformType.h"

//------------------------------------------------------------------
// Transfer the platform types to global types
//------------------------------------------------------------------

//~ Unsigned base types.
/// An 8-bit unsigned integer.
typedef FPlatformTypes::uint8		uint8;
/// A 16-bit unsigned integer.
typedef FPlatformTypes::uint16		uint16;
/// A 32-bit unsigned integer.
typedef FPlatformTypes::uint32		uint32;
/// A 64-bit unsigned integer.
typedef FPlatformTypes::uint64		uint64;

//~ Signed base types.
/// An 8-bit signed integer.
typedef	FPlatformTypes::int8		int8;
/// A 16-bit signed integer.
typedef FPlatformTypes::int16		int16;
/// A 32-bit signed integer.
typedef FPlatformTypes::int32		int32;
/// A 64-bit signed integer.
typedef FPlatformTypes::int64		int64;

//~ Character types.
/// An ANSI character. Normally a signed type.
typedef FPlatformTypes::ANSICHAR	ANSICHAR;
/// A wide character. Normally a signed type.
typedef FPlatformTypes::WIDECHAR	WIDECHAR;
/// Either ANSICHAR or WIDECHAR, depending on whether the platform supports wide characters or the requirements of the licensee.
typedef FPlatformTypes::TCHAR		T_CHAR;
/// An 8-bit character containing a UTF8 (Unicode, 8-bit, variable-width) code unit.
typedef FPlatformTypes::CHAR8		UTF8CHAR;
/// A 16-bit character containing a UCS2 (Unicode, 16-bit, fixed-width) code unit, used for compatibility with 'Windows TCHAR' across multiple platforms.
typedef FPlatformTypes::CHAR16		UCS2CHAR;
/// A 16-bit character containing a UTF16 (Unicode, 16-bit, variable-width) code unit.
typedef FPlatformTypes::CHAR16		UTF16CHAR;
/// A 32-bit character containing a UTF32 (Unicode, 32-bit, fixed-width) code unit.
typedef FPlatformTypes::CHAR32		UTF32CHAR;

/// An unsigned integer the same size as a pointer
typedef FPlatformTypes::UPTRINT UPTRINT;
/// A signed integer the same size as a pointer
typedef FPlatformTypes::PTRINT PTRINT;
/// An unsigned integer the same size as a pointer, the same as UPTRINT
typedef FPlatformTypes::SIZE_T SIZET;
/// An integer the same size as a pointer, the same as PTRINT
typedef FPlatformTypes::SSIZE_T SSIZET;

/// The type of the NULL constant.
typedef FPlatformTypes::TYPE_OF_NULL	TYPE_OF_NULL;
/// The type of the C++ nullptr keyword.
typedef FPlatformTypes::TYPE_OF_NULLPTR	TYPE_OF_NULLPTR;

using T_String = std::basic_string<T_CHAR>;


//------------------------------------------------------------------
// Test the global types
//------------------------------------------------------------------
namespace TypeTests
{
	template <typename A, typename B>
	struct TAreTypesEqual
	{
		enum { Value = false };
	};

	template <typename T>
	struct TAreTypesEqual<T, T>
	{
		enum { Value = true };
	};

	// static_assert(!PLATFORM_TCHAR_IS_4_BYTES || sizeof(TCHAR) == 4, "TCHAR size must be 4 bytes.");
	// static_assert(PLATFORM_TCHAR_IS_4_BYTES || sizeof(TCHAR) == 2, "TCHAR size must be 2 bytes.");
	//
	// static_assert(PLATFORM_32BITS || PLATFORM_64BITS, "Type tests pointer size failed.");
	// static_assert(PLATFORM_32BITS != PLATFORM_64BITS, "Type tests pointer exclusive failed.");
	// static_assert(!PLATFORM_64BITS || sizeof(void*) == 8, "Pointer size is 64bit, but pointers are short.");
	// static_assert(PLATFORM_64BITS || sizeof(void*) == 4, "Pointer size is 32bit, but pointers are long.");

	static_assert(char(-1) < char(0), "Unsigned char type test failed.");

	static_assert((!TAreTypesEqual<ANSICHAR, WIDECHAR>::Value), "ANSICHAR and WIDECHAR should be different types.");
	static_assert((!TAreTypesEqual<ANSICHAR, UCS2CHAR>::Value), "ANSICHAR and CHAR16 should be different types.");
	static_assert((!TAreTypesEqual<WIDECHAR, UCS2CHAR>::Value), "WIDECHAR and CHAR16 should be different types.");
	static_assert((TAreTypesEqual<TCHAR, ANSICHAR>::Value || TAreTypesEqual<TCHAR, WIDECHAR>::Value), "TCHAR should either be ANSICHAR or WIDECHAR.");

	static_assert(sizeof(uint8) == 1, "BYTE type size test failed.");
	static_assert(int32(uint8(-1)) == 0xFF, "BYTE type sign test failed.");

	static_assert(sizeof(uint16) == 2, "WORD type size test failed.");
	static_assert(int32(uint16(-1)) == 0xFFFF, "WORD type sign test failed.");

	static_assert(sizeof(uint32) == 4, "DWORD type size test failed.");
	static_assert(int64(uint32(-1)) == int64(0xFFFFFFFF), "DWORD type sign test failed.");

	static_assert(sizeof(uint64) == 8, "QWORD type size test failed.");
	static_assert(uint64(-1) > uint64(0), "QWORD type sign test failed.");


	static_assert(sizeof(int8) == 1, "SBYTE type size test failed.");
	static_assert(int32(int8(-1)) == -1, "SBYTE type sign test failed.");

	static_assert(sizeof(int16) == 2, "SWORD type size test failed.");
	static_assert(int32(int16(-1)) == -1, "SWORD type sign test failed.");

	static_assert(sizeof(int32) == 4, "INT type size test failed.");
	static_assert(int64(int32(-1)) == int64(-1), "INT type sign test failed.");

	static_assert(sizeof(int64) == 8, "SQWORD type size test failed.");
	static_assert(int64(-1) < int64(0), "SQWORD type sign test failed.");

	static_assert(sizeof(ANSICHAR) == 1, "ANSICHAR type size test failed.");
	static_assert(int32(ANSICHAR(-1)) == -1, "ANSICHAR type sign test failed.");

	static_assert(sizeof(WIDECHAR) == 2 || sizeof(WIDECHAR) == 4, "WIDECHAR type size test failed.");

	static_assert(sizeof(UCS2CHAR) == 2, "UCS2CHAR type size test failed.");

	static_assert(sizeof(uint32) == 4, "BITFIELD type size test failed.");
	static_assert(int64(uint32(-1)) == int64(0xFFFFFFFF), "BITFIELD type sign test failed.");

	static_assert(sizeof(PTRINT) == sizeof(void*), "PTRINT type size test failed.");
	static_assert(PTRINT(-1) < PTRINT(0), "PTRINT type sign test failed.");

	static_assert(sizeof(UPTRINT) == sizeof(void*), "UPTRINT type size test failed.");
	static_assert(UPTRINT(-1) > UPTRINT(0), "UPTRINT type sign test failed.");

	static_assert(sizeof(SIZE_T) == sizeof(void*), "SIZE_T type size test failed.");
	static_assert(SIZE_T(-1) > SIZE_T(0), "SIZE_T type sign test failed.");
}
