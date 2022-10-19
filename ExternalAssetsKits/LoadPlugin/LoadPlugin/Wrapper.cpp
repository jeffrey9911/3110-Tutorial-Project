#include "Wrapper.h"
#include "GameObject.h"

GameObject gameObject;

PLUGIN_API float LoadFromFile(int j, const char* fileName)
{
	return gameObject.loadFromFile(j, fileName);
}

PLUGIN_API int GetLines(const char* fileName)
{
	return gameObject.GetLines(fileName);
}
