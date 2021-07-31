#pragma once

#include <memory>

#include "EditorGUI_API.h"
#include "IView.h"

class EditorGUI_API SceneView : public IView
{
public:
	const std::string& GetTitle() const override;
	
	void OnInit() override;

	void OnGUI() override;

	void ShutDown() override;

private:

	class GameObject* cameraObj;
	std::shared_ptr <class Camera > camera;
	std::shared_ptr<class RenderTexture> showTexture;

	float lastWidth;
	float lastHeight;
};
