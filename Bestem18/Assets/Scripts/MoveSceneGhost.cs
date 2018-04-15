using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneGhost : MonoBehaviour
{
    [SerializeField] private string loadLevel;
    private bool colliding;

    void Start()
    {
        gameObject.transform.position = GameManager.currentPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Body"))
        {
            colliding = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            colliding = false;
        }
    }

    void Update()
    {
        if(colliding && Input.GetKeyDown(KeyCode.Q))
        {
            //SceneManager.LoadScene(loadLevel);
            SceneManager.LoadScene(1);
        }
    }
    /*
        void Update()
        {
            if((Input.GetKeyDown(KeyCode.Q)) )
            {
                SceneManager.LoadScene(loadLevel);
            }
        }
    /*
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(loadLevel);
            }
        }
    */
}
