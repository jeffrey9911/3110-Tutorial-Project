#include "Wrapper.h"

#include "GameObject.h"

GameObject gameObject;

PLUGIN_API int GetID()
{
	return gameObject.GetID();
}

PLUGIN_API void SetID(const int id)
{
	gameObject.SetID(id);
}

PLUGIN_API Vector3 GetPosition()
{
	return gameObject.GetPosition();
}

PLUGIN_API void SetPosition(float x, float y, float z)
{
	gameObject.SetPosition(x, y, z);
}

PLUGIN_API void SaveToFile(int id, float x, float y, float z)
{
	gameObject.SaveToFile(id, x, y, z);
}

PLUGIN_API void StartWriting(const char* fileName)
{
	gameObject.StartWriting(fileName);
}

PLUGIN_API void EndWriting()
{
	gameObject.EndWriting();
}
