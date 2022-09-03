using UnityEngine;
using UnityEditor;

public class Script_03_17 
{
	[InitializeOnLoadMethod]
	static void InitializeOnLoadMethod(){
		SceneView.onSceneGUIDelegate = delegate(SceneView sceneView) {
			Handles.BeginGUI();

			GUI.Label(new Rect(0f,0f,50f,15f),"标题");
			GUI.Button(new Rect(0f,20f,50f,50f),
				AssetDatabase.LoadAssetAtPath<Texture>("Assets/unity.png"));


			Handles.EndGUI();
		};
	}

}
