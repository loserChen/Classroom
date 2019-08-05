using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HummerController : MonoBehaviour {

	public GameObject particle;
	public AudioClip hitSE;

	AudioSource audio;

	void Start () {
		this.audio = GetComponent<AudioSource> ();	
	}

	IEnumerator Hit(Vector3 target)
	{
		// Hummer Down		
		transform.position = new Vector3(target.x, 25, target.z);

		// Impact
		Instantiate (this.particle, transform.position, Quaternion.identity);

		Camera.main.GetComponent<CameraController>().Shake();

		this.audio.PlayOneShot (this.hitSE);

		yield return new WaitForSeconds (0.1f);

		// Hummer Up
		for (int i = 0; i < 6; i++) 
		{
			transform.Translate (0, 0, 1.0f);
			yield return null;
		}
        yield return new WaitForSeconds(0.1f);
        transform.Translate(0, 0, 1000f);
    }

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 1000)) 
			{
				GameObject mole = hit.collider.gameObject;
                GameObject[] gos = GameObject.FindGameObjectsWithTag("Mole");
                GameObject goes = GameObject.FindGameObjectWithTag("Mole_Hat");
                bool isHit = false;
                if (mole == goes)
                {
                    isHit = mole.GetComponent<MoleController>().Hit();
                }
                else
                {
                    foreach (GameObject go in gos)
                    {
                        if (mole == go)
                        {
                            isHit = mole.GetComponent<MoleController>().Hit();
                        }
                    }
                }
				// if hit the mole, show hummer and effect
				if (isHit) 
				{
					StartCoroutine (Hit (mole.transform.position));
                    if (mole.tag == "Mole_Hat")
                    {
                        ScoreManager.score += 50;
                    }
                    else
                    {
                        ScoreManager.score += 10;
                    }
				}
			}
		}
	}
}
