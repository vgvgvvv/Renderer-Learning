#include "GameView.h"

DEFINE_DRIVEN_CLASS_IMP(GameView, IView)
DEFINE_VIEW_IMP(GameView, Game)

void GameView::OnInit()
{
	Super::OnInit();
}

void GameView::OnGUI(float deltaTime)
{
	Super::OnGUI(deltaTime);
}

void GameView::ShutDown()
{
	Super::ShutDown();
}
