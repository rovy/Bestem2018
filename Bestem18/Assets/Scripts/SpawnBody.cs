using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBody : MonoBehaviour {

    void Start()
    {
        gameObject.transform.position = GameManager.currentPosition;
    }

    void Update()
    {
        
    }

}
