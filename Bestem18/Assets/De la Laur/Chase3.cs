using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase3 : MonoBehaviour {

	public Transform player;
	static Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{

		Vector3 direction = player.position - this.transform.position;

		if (Vector3.Distance (player.position, this.transform.position) < 10) 
		{


			direction.y = 0;

			anim.SetBool ("isDead", false);

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f); 

			if (direction.magnitude > 0.5) {
				this.transform.Translate (0, 0, 0.025f);
			}
			else 
			{
				anim.SetBool ("isDead", true);

			}
		}

	}
}