#pragma once
#include <memory>

template<class T>
class BaseAssetObject
{

	
protected:
	std::shared_ptr<T> assetPtr;
	
};
