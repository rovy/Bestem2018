using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    Animator anim;
    public int doorNumber;
    private bool colliding;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            colliding = false;
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

        if(GameManager.doorOpen[doorNumber] == true)
        {
            anim.SetTrigger("OpenDoor");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(doorNumber == 0)
        {
            if (colliding && Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("OpenDoor");
                GameManager.doorOpen[doorNumber] = true;
            }
        }

        if ((doorNumber == 1) || (doorNumber == 2))
        {
            if (colliding && Input.GetKeyDown(KeyCode.E) && GameManager.key)
            {
                anim.SetTrigger("OpenDoor");
                GameManager.doorOpen[doorNumber] = true;
            }
        }
	}
/*
    void OnTriggerEnter(Collider other)
    {
        // daca e apasat butonul E atunci se deschide
        // merge doar daca personajul e fantoma
        if(other.CompareTag("Player"))
        {
            anim.SetTrigger("OpenDoor");
            GameManager.doorOpen[doorNumber] = true;
        }
    }

 /*   void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }
*/

    void PauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
