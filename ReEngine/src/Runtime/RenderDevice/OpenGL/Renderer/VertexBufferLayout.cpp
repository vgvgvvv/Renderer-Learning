#include "VertexBufferLayout.h"


void VertexBufferLayout::PushVector2()
{
	Push<float>(2);
}

void VertexBufferLayout::PushVector3()
{
	Push<float>(3);
}

void VertexBufferLayout::PushVector4()
{
	Push<float>(4);
}

void VertexBufferLayout::PushUV()
{
	Push<float>(2);
}

void VertexBufferLayout::PushColor()
{
	Push<float>(4);
}
