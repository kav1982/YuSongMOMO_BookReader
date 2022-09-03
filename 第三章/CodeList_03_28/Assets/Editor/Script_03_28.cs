using UnityEngine;
using UnityEditor;
using System.Reflection;

public class Script_03_28 
{
	[MenuItem("Tools/CreateConsole")]
	static void CreateConsole()
	{
		Debug.Log ("CreateConsole");
	}

	[MenuItem("Tools/CleanConsole")]
	static void CleanConsole()
	{
		//获取assembly
		Assembly assembly = Assembly.GetAssembly (typeof(Editor));
		//反射获取LogEntries对象
		MethodInfo methodInfo = assembly.GetType("UnityEditor.LogEntries").
			GetMethod("Clear");
		//调用Clear方法
		methodInfo.Invoke(new object(), null);
	}
}
