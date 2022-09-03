using UnityEngine;
using UnityEditor;

public class Script_03_05
{
	[MenuItem("GameObject/My Create/Cube",false,0)]
	static void CreateCube()
	{
		GameObject.CreatePrimitive (PrimitiveType.Cube); //创建立方体
	}
}
