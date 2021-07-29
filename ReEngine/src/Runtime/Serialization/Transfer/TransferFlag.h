#pragma once

enum class TransferFlag
{
	None = 0,
	IgnoreInMeta = 1 << 1,

	// 正在加载
	IsLoading = 1 << 2,
	// 正在写入
	IsWriting = 1 << 3,

	//正在用于绘制界面
	IsDrawingGUI = 1 << 4,
	//绘制方式采用只读 
	DrawReadOnly = 1 << 5,
};