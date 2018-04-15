using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

	public Transform player;
	static Animator anim;

	string state = "patrol";
	public GameObject[] waypoints;
	int currentWP = 0;
	public float rotSpeed = 0.2f;
	public float speed = 1.5f;
	float accuracyWP = 5.0f;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 direction = player.position - this.transform.position;
		float angle = Vector3.Angle(direction,this.transform.forward);


		direction.y = 0;

        if (state == "patrol" && waypoints.Length > 0) {


			if (Vector3.Distance (waypoints [currentWP].transform.position, transform.position) < accuracyWP) {

				currentWP++;
				if (currentWP >= waypoints.Length) {
					currentWP = 0;
				}
			}

			direction = waypoints [currentWP].transform.position - transform.position;

			this.transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (direction), rotSpeed * Time.deltaTime);
			this.transform.Translate (0, 0, Time.deltaTime * speed);


		}


		if (Vector3.Distance (player.position, this.transform.position) < 10 && (angle < 2.5 || state == "pursuing")) {
			
			state = "pursuing";

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), rotSpeed * Time.deltaTime);

			if (direction.magnitude >= 0) {
				this.transform.Translate (0, 0, 0.1f);
			} 
	

		} else {
			state = "patrol";
		}

	}
}
