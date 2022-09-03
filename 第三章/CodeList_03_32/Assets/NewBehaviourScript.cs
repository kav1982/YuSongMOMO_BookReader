using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
	public static GameObject prefab;
	void Start () {
		prefab = Resources.Load<GameObject> ("prefab");
	}
}
