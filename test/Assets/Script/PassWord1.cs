using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassWord1 : MonoBehaviour {
    public Material[] material;
    public GameObject cube1, cube2, cube3, cube4;
    Renderer rend;
    public bool Ifsolve=false;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
	
	// Update is called once per frame
	void Update () {
        int p1 = cube1.GetComponent<PassWordlock>().num;
        int p2 = cube2.GetComponent<PassWordlock>().num;
        int p3 = cube3.GetComponent<PassWordlock>().num;
        int p4 = cube4.GetComponent<PassWordlock>().num;
        if (p1 == 4 && p2 == 6 && p3 == 6 && p4 == 5)
        {
            rend.sharedMaterial = material[1];
            Ifsolve = true;
        }
    }
}
