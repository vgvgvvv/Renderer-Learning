#pragma once
#include <memory>

#include "Layer/Layer.h"

#include "Core_API.h"

class Core_API WindowLayer : public Layer
{
	DEFINE_DRIVEN_CLASS(WindowLayer, Layer)
public:
	WindowLayer() = default;
	~WindowLayer() override = default;
	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnBeforeRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;
	bool ShouldQuit() override;

	class IGenericWindow& GetWindow() const { return *window; }
	
private:
	std::shared_ptr<class IGenericWindow> window;
};
