using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GUIText endText;
    private bool gameEnded;
    public Scene scene;
    public GameObject door1, door2, door3,door;
	// Use this for initialization
	void Start () {
        gameEnded = false;
        endText.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
        int p1 = door1.GetComponent<DoorPassWord>().num;
        int p2 = door2.GetComponent<DoorPassWord>().num;
        int p3 = door3.GetComponent<DoorPassWord>().num;
        if (p1 == 6 && p2 == 8 && p3 == 2)
        {
            gameEnded = true;
            endText.gameObject.SetActive(true);
        }
        if (gameEnded)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("game");
            }
        }
    }
}
