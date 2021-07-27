#pragma once


class IBaseTransfer
{
public:
	virtual ~IBaseTransfer() = default;
	virtual bool IsReading() { return false; }
	virtual bool IsWriting() { return false; }
};