#include "VertexBufferLayout.h"

void VertexBufferLayout::PushVector3()
{
	Push<float>(3);
}

void VertexBufferLayout::PushUV()
{
	Push<float>(2);
}

void VertexBufferLayout::PushColor()
{
	Push<float>(3);
}
