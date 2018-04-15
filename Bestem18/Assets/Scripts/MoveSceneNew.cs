using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSceneNew : MonoBehaviour {



	void Start () {
		
	}


	

	void Update () {

        if(CollisionWithGuard.dead == false)
        {
            GameManager.currentPosition.x = gameObject.transform.position.x;
            GameManager.currentPosition.y = gameObject.transform.position.y;
            GameManager.currentPosition.z = gameObject.transform.position.z;
        }        

    }
}
