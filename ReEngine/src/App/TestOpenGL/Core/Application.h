#pragma once


class Application
{
public:
	int Run();
protected:
	void Init();
	void Update();
	void Uninit();
	bool ShouldQuit();
};