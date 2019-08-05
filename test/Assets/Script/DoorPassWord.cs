using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPassWord : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    public int num = 0;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
            if (num == 0)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 1)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 2)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 3)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 4)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 5)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 6)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 7)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 8)
            {
                num++;
                rend.sharedMaterial = material[num];

            }
            else if (num == 9)
            {
                num = 0;
                rend.sharedMaterial = material[num];

            }
        



    }
    // Update is called once per frame
    void Update()
    {

    }
}
