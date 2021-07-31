#pragma once

#include <memory>

#include "EditorGUI_API.h"
#include "IView.h"
#include "DefineView.h"

class EditorGUI_API SceneView : public IView
{
	DEFINE_VIEW(SceneView, Scene)

private:

	class GameObject* cameraObj;
	std::shared_ptr <class Camera > camera;
	std::shared_ptr<class RenderTexture> showTexture;

	float lastWidth;
	float lastHeight;
};
