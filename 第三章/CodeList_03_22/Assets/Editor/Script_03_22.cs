using UnityEngine;
using UnityEditor;

public class Script_03_22 
{
	[MenuItem("Assets/HotKey %#d",false,-1)]
	private static void HotKey()
	{
		Debug.Log ("Command Shift + D");
	}
}

