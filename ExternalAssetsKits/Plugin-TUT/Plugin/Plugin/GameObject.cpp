#include "GameObject.h"

GameObject::GameObject()
{
	SetID();
	SetPosition();
}

int GameObject::GetID() const
{
	return m_id;
}

void GameObject::SetID(const int id)
{
	m_id = id;
}

Vector3 GameObject::GetPosition()
{
	return m_position;
}

void GameObject::SetPosition(float x, float y, float z)
{
	m_position.x = x;
	m_position.y = y;
	m_position.z = z;
}

void GameObject::SaveToFile(int objectID, float x, float y, float z)
{

	WriteFile << objectID << "\n";
	WriteFile << x << "\n";
	WriteFile << y << "\n";
	WriteFile << z << "\n";
}

void GameObject::StartWriting(const char* fileName)
{
	WriteFile.open(fileName);
}

void GameObject::EndWriting()
{
	WriteFile.close();
}
