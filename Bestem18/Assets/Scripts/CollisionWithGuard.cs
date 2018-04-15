using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWithGuard : MonoBehaviour {

    public static bool dead = false;
    [SerializeField] private string loadLevel;

    // Use this for initialization
    void Start () {
		
	}

    void ResetVariables()
    {
        GameManager.killPill = 0;

        GameManager.currentPosition.x = 13;
        GameManager.currentPosition.y = 0;
        GameManager.currentPosition.z = -13;

        GameManager.killPillExists[0] = true;
        GameManager.killPillExists[1] = true;
        GameManager.killPillExists[2] = true;

        GameManager.doorOpen[0] = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Guard"))
        {
            dead = true;
            ResetVariables();
            SceneManager.LoadScene(loadLevel);
        }

        if(other.CompareTag("Fin"))
        {
            dead = true;
            ResetVariables();
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
