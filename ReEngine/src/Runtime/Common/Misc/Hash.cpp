#include "Hash.h"

namespace CommonLib
{
	constexpr uint64_t Hash(char const* const str, uint64_t const value) noexcept
	{
		return (str[0] == '\0')
			? value
			: Hash(&str[1], (value ^ uint64_t(str[0])) * kFNV1aPrime);
	}
}
