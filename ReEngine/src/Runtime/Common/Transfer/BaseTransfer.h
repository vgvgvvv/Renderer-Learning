#pragma once


class IBaseTransfer
{
public:
	virtual ~IBaseTransfer() = default;
	virtual bool IsLoading() { return false; }
	virtual bool IsWriting() { return false; }
	virtual bool IsImGui() { return false; }
};