using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour {

	public float moveSpeed;
	public float waitTime = 1.0f;

	private const float TOP = 10.0f;
	private const float BOTTOM = 10.0f;
	private float tmpTime = 0;

	enum State{
		UNDER_GROUND,
		UP,
		ON_GROUND,
		DOWN,
		HIT,
	}
	State state;
    bool flag;
    float pos;

	public void Up()
	{
		if (this.state == State.UNDER_GROUND) 
		{
			this.state = State.UP;
		}
	}

	public bool Hit()
	{
		// if mole is under ground, never hit
		if (this.state == State.UNDER_GROUND) 
		{
			return false;
		}

		// hit to bottom
		transform.position = 
			new Vector3(transform.position.x, transform.position.y-BOTTOM, transform.position.z);

		this.state = State.UNDER_GROUND;

		return true;
	}
		
	void Start () 
	{
		this.state = State.UNDER_GROUND;
        moveSpeed = 3f;
        flag = true;
        pos = 0.0f;
	}
		
	void Update () 
	{
        if(flag){
            pos = transform.position.y;
            flag = false;
        }
		if (this.state == State.UP) 
		{
			transform.Translate (0, this.moveSpeed, 0);

			if (transform.position.y > TOP) 
			{
				transform.position = 
					new Vector3 (transform.position.x,pos+TOP, transform.position.z);

				this.state = State.ON_GROUND;

				this.tmpTime = 0;
			}
		} 
		else if (this.state == State.ON_GROUND)
		{
			this.tmpTime += Time.deltaTime;

			if (this.tmpTime > this.waitTime) 
			{
				this.state = State.DOWN;
			}
		}
		else if (this.state == State.DOWN) 
		{
			transform.Translate (0, -this.moveSpeed, 0);

			if (transform.position.y < pos) 
			{
				transform.position = 
					new Vector3(transform.position.x, pos, transform.position.z);

				this.state = State.UNDER_GROUND;
			}
		}
	}
}
