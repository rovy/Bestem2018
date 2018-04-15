using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSceneNormal : MonoBehaviour {

    [SerializeField] private string loadLevel;

    // Use this for initialization
    void Start () {
        gameObject.transform.position = GameManager.currentPosition;
    }
	
	// Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Q)) && (GameManager.killPill > 0))
        {
            //SceneManager.LoadScene(loadLevel);
            SceneManager.LoadScene(2);
            GameManager.killPill--;

            GameManager.currentPosition.x = gameObject.transform.position.x;
            GameManager.currentPosition.y = gameObject.transform.position.y;
            GameManager.currentPosition.z = gameObject.transform.position.z;
            //print("kill pill count: " + GameManager.killPill);

        }
    }
}
