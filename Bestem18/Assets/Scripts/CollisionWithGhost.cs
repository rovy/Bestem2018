using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithGhost : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ghost"))
        {
            rb.isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
