#pragma once

#include <memory>

#include "EditorGUI_API.h"

class EditorGUI_API SceneView
{
public:
	void OnInit();

	void OnGUI();

	void ShutDown();

private:

	class GameObject* cameraObj;
	std::shared_ptr <class Camera > camera;
	std::shared_ptr<class RenderTexture> showTexture;

	float lastWidth;
	float lastHeight;
};
