#include "D3DApp.h"


#include "Layers/WindowLayer.h"
#include "Layers/WorldLayer.h"
#include "Layers/RenderLayer.h"


void D3DApp::Init()
{
	LayerManager.PushLayer(new WindowLayer());
	LayerManager.PushLayer(new RenderLayer());
	LayerManager.PushLayer(new WorldLayer());
}
