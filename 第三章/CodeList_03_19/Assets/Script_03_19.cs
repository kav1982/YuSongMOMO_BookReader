using UnityEngine;
#if UNITY_EDITOR
[ExecuteInEditMode]
public class Script_03_19 : MonoBehaviour 
{
	void OnGUI()
	{
		if (GUILayout.Button ("Click")) {
			Debug.Log ("click!!!");
		}
		GUILayout.Label ("Hello World!!!");
	}
}
#endif
