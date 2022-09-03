using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_02 : MonoBehaviour {

	#if UNITY_EDITOR
	void Reset () 
	{
		Debug.LogFormat ("GameObject:{0} 绑定 Script_04_02.cs 脚本", gameObject.name);
	}
	#endif
}
