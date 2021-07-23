#pragma once

#include <memory>

#include "EditorGUI_API.h"

class GameObject;
class RenderTexture;
class Texture;
class Camera;

class EditorGUI_API SceneView
{
public:
	void OnInit();

	void OnGUI();

	void ShutDown();

private:

	GameObject* cameraObj;
	std::shared_ptr<Camera> camera;
	std::shared_ptr<RenderTexture> showTexture;
};
