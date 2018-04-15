using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour {

    private bool colliding;
    public GameObject exclamationPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KeyHolder"))
        {
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("KeyHolder"))
        {
            colliding = false;
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (colliding && Input.GetKeyDown(KeyCode.E))
        {
            GameManager.key = true;
            Destroy(exclamationPoint);
        }
    }
}
