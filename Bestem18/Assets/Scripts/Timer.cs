using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    float timeLeft = 20.0f;
	public Text text;
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

    // Update is called once per frame
    void Update () {
		timeLeft -= Time.deltaTime;
		text.text = "Time left dead: " + Mathf.Round (timeLeft);

		if (timeLeft < 0) {
            CollisionWithGuard.dead = true;
            ResetVariables();
            SceneManager.LoadScene(loadLevel);
		}
			
	}
}
