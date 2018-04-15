using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDoorScript : MonoBehaviour {

    private bool colliding;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            colliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            colliding = false;
        }
    }

    void Update()
    {
        if (colliding && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
