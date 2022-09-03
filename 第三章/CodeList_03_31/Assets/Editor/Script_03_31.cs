using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(UnityEditor.DefaultAsset))]
public class Script_03_31 :Editor
{
	public override void OnInspectorGUI ()
	{
		string path = AssetDatabase.GetAssetPath(target);
		GUI.enabled = true;
		if(path.EndsWith(string.Empty)){
			GUILayout.Label ("拓展文件夹");
			GUILayout.Button("我是文件夹");
		}
	}
}
