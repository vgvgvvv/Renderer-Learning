#pragma once


class IBaseTransfer
{
public:
	virtual ~IBaseTransfer() = default;
	virtual bool IsLoading() const { return false; }
	virtual bool IsWriting() const { return false; }
	virtual bool IsImGui() const { return false; }
};