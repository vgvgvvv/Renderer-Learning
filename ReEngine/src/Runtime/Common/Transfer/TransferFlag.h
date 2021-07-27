#pragma once

enum class TransferFlag
{
	None = 0,
	IgnoreInMeta = 1 << 1,

	// ���ڼ���
	IsLoading = 1 << 2,
	// ����д��
	IsWriting = 1 << 3,

	//�������ڻ��ƽ���
	IsDrawingGUI = 1 << 4,
	//���Ʒ�ʽ����ֻ�� 
	DrawReadOnly = 1 << 5,
};