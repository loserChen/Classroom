using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewScene : MonoBehaviour {
    public string levelName;
	// Use this for initialization
	void Start () {
        if (levelName.Length > 0)
        {
            Application.LoadLevelAdditive(levelName);
            Debug.Log("level add successfully!");
        }
        else
        {
            Debug.Log("level is not added!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
