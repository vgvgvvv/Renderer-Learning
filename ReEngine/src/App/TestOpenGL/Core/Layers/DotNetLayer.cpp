#include "DotNetLayer.h"

void DotNetLayer::OnInit()
{
	Manager.Init();
}

void DotNetLayer::OnPreUpdate()
{
}

void DotNetLayer::OnUpdate()
{
}

void DotNetLayer::OnLateUpdate()
{
}

void DotNetLayer::OnBeforeRender()
{
}

void DotNetLayer::OnRender()
{
}

void DotNetLayer::OnAfterRender()
{
}

void DotNetLayer::OnShutDown()
{
	Manager.Uninit();
}
