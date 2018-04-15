using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPillIncrement : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.killPill++;
            print("kill pill count: " + GameManager.killPill);
            Destroy(gameObject);
        }
    }
}
