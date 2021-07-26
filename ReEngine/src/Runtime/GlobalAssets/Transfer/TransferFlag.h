#pragma once

enum class TransferFlag
{
	None = 0,
	IgnoreInMeta = 1 << 1,

	// 正在加载
	IsLoading = 1 << 2,
	// 正在写入
	IsWriting = 1 << 3
};