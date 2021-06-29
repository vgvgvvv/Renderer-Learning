#include <iostream>
#include "Misc/Path.h"

using namespace std;
int main()
{
	cout << Path::GetCurrentExeFilePath() << endl;
	return 0;
}