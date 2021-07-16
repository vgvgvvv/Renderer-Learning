#pragma once
#include <cstdint>

namespace CommonLib
{
    static constexpr uint64_t kFNV1aValue = 0xcbf29ce484222325;
    static constexpr uint64_t kFNV1aPrime = 0x100000001b3;
	
    inline constexpr uint64_t
        Hash(char const* const str, uint64_t const value = kFNV1aValue) noexcept;
}
