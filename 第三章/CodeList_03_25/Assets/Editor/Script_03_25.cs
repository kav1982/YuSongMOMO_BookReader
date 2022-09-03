using UnityEngine;
using UnityEditor;

public class Script_03_25 : EditorWindow ,IHasCustomMenu
{
	#region IHasCustomMenu implementation
	void IHasCustomMenu.AddItemsToMenu (GenericMenu menu)
	{
		menu.AddDisabledItem (new GUIContent ("Disable"));
		menu.AddItem (new GUIContent ("Test1"), true, ()=> {
			Debug.Log("Test1");
		});
		menu.AddItem (new GUIContent ("Test2"), true, ()=> {
			Debug.Log("Test2");
		});
		menu.AddSeparator ("Test/");
		menu.AddItem (new GUIContent ("Test/Tes3"), true, ()=> {
			Debug.Log("Tes3");
		});
	
	}
	#endregion

	[MenuItem("Window/Open My Window")]
	static void Init()
	{
		Script_03_25 window = (Script_03_25)EditorWindow.GetWindow(typeof(Script_03_25));
		window.Show();
	}
}