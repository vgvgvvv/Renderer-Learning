#pragma once

#include <list>

#include "Behavior.h"
#include "Color.h"
#include "Singleton.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API Camera : public Behavior
{
public:

	Camera();
	
	void Awake() override;

	void BeginDestroy() override;
	
	void Render();

	Color ClearColor;

};

class RenderPipeline_API CameraManager
{
	DEFINE_SINGLETON(CameraManager);

public:

	void Add(Camera* camera);
	void Remove(Camera* camera);

	const std::list<Camera*>& GetCameraList() const { return cameraList; }

private:
	std::list<Camera*> cameraList;
};