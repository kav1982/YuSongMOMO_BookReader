﻿using UnityEngine;
using UnityEditor;


public class Script_03_21 
{
	[InitializeOnLoadMethod]
	static void InitializeOnLoadMethod()
	{
		SceneView.onSceneGUIDelegate = delegate(SceneView sceneView) {
			Event e = Event.current;
			//鼠标右键抬起时
			if(e != null && e.button ==1 && e.type == EventType.MouseUp){
				Vector2 mousePosition = e.mousePosition;
				//设置菜单项
				var options = new GUIContent[]{
					new GUIContent("Test1"),
					new GUIContent("Test2"),
					new GUIContent(""),
					new GUIContent("Test/Test3"),
					new GUIContent("Test/Test4"),	
				};
				//设置菜单显示区域
				var selected= -1;
				var userData=Selection.activeGameObject;
				var width =100;
				var height =100;
				var position =new Rect(mousePosition.x,mousePosition.y - height,width,height);
				//显示菜单
				EditorUtility.DisplayCustomMenu(position,options,selected,delegate(object data, string[] opt, int select) {
					Debug.Log(opt[select]);
				},userData);
				e.Use();
			}
		};
	}
}

