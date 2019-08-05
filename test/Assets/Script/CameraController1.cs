using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController1 : MonoBehaviour {

    private GameObject gameObject;
    public float xMax, xMin, zMax, zMin,yMin,yMax;
    float x1;
    float x2;
    float x3;
    float x4;
    void Start()
    {
        gameObject = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >xMax)
        {
            gameObject.transform.position = new Vector3(xMax, this.gameObject.transform.position.y, this.gameObject.transform.position.z); ;
        }
        if (this.transform.position.x < xMin)
        {
            gameObject.transform.position = new Vector3(xMin, this.gameObject.transform.position.y, this.gameObject.transform.position.z); ;
        }
        if (this.transform.position.z > zMax)
        {
            gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, zMax); ;
        }
        if (this.transform.position.z <zMin)
        {
            gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, zMin); ;
        }
        if (this.transform.position.y > yMax)
        {
            gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, yMax, this.gameObject.transform.position.z); ;
        }
        if (this.transform.position.y < yMin)
        {
            gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, yMin, this.gameObject.transform.position.z); ;
        }

        //w键前进
        if (Input.GetKey(KeyCode.W))
            {
                this.gameObject.transform.Translate(new Vector3(0, 0, 50 * Time.deltaTime));
            }
            //s键后退
            if (Input.GetKey(KeyCode.S))
            {
                this.gameObject.transform.Translate(new Vector3(0, 0, -50 * Time.deltaTime));
            }
            //a键向左
            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(new Vector3(-10, 0, 0 * Time.deltaTime));
            }
            //d键向右
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(new Vector3(10, 0, 0 * Time.deltaTime));
            }
        //C键向上
        if (Input.GetKey(KeyCode.C))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
        //Z键向下
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position=new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
        //q键向左转
        if (Input.GetKey(KeyCode.Q))
        {
            this.gameObject.transform.Rotate(new Vector3(0, -30 * Time.deltaTime, 0));
        }
        //e键向右转
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.transform.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
        }
    }
   
}
