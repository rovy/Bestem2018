using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPillScript : MonoBehaviour {

    public int killPillNumber;

	// Use this for initialization
	void Start () {
		if(GameManager.killPillExists[killPillNumber] == false)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.killPillExists[killPillNumber] = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
