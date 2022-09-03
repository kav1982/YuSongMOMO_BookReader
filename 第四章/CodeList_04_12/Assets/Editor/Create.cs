﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Create 
{
	[MenuItem("Assets/Create ScriptableObject")]
	static void CreateScriptableObject () 
	{
		//创建ScriptableObject
		Script_04_12 script = ScriptableObject.CreateInstance<Script_04_12> ();
		//赋值
		script.m_PlayerInfo = new List<Script_04_12.PlayerInfo> ();
		script.m_PlayerInfo.Add (new Script_04_12.PlayerInfo (){ id = 100, name = "Test" });

		//将资源保存到本地
		AssetDatabase.CreateAsset (script, "Assets/Resources/Create Script_04_12.asset");
		AssetDatabase.SaveAssets ();
		AssetDatabase.Refresh ();
	}
}
