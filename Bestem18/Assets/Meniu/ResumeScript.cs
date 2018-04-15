using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeScript : MonoBehaviour {
    private Scene lastScene;
    public bool paused;
	// Use this for initialization
	private void Start () {
        paused = false;
	}

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            paused = !paused;
        }

        if (paused)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(3);
            lastScene = SceneManager.GetActiveScene();
        }
        else if (!paused) {
            Time.timeScale = 1;
            SceneManager.LoadScene(lastScene.name);
        }
    }



    public void Resume() {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            paused = !paused;
        }

        if (paused)
        {
            //Time.timeScale = 0;
            lastScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(3);
        }
        else if (!paused)
        {
           // Time.timeScale = 1;
            SceneManager.LoadScene(lastScene.name);
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
