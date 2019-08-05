using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleManager : MonoBehaviour {

	List<MoleController> moles = new List<MoleController>();
	bool generate;
	public AnimationCurve maxMoles;
    public float proSpeed;
	// Use this for initialization
	void Start () 
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag ("Mole");
		foreach (GameObject go in gos) 
		{
			moles.Add (go.GetComponent<MoleController> ());
		}
        GameObject goes = GameObject.FindGameObjectWithTag("Mole_Hat");
        moles.Add(goes.GetComponent<MoleController>());
        this.generate = false;
        proSpeed = 1.2f;
	}

	public void StartGenerate()
	{
		StartCoroutine ("Generate");
	}

	public void StopGenerate()
	{
		this.generate = false;
	}
		
	IEnumerator Generate()
	{
		this.generate = true;

		while (this.generate) 
		{
			// wait to generate next group
			yield return new WaitForSeconds (1.2f);

			int n = moles.Count;
			int maxNum = (int)this.maxMoles.Evaluate ( GameManager.time );

			for (int i = 0; i < maxNum; i++) 
			{
                // select mole to up
                if (this.generate)
                {
                    this.moles[Random.Range(0, n)].Up();
                }
								
                yield return new WaitForSeconds (proSpeed);
			}
		}
	}
}
