#pragma once

enum class TransferFlag
{
	None = 0,
	IgnoreInMeta = 1 << 1,

	// ���ڼ���
	IsLoading = 1 << 2,
	// ����д��
	IsWriting = 1 << 3
};