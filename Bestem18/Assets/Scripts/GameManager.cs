using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int killPill = 0;
    public static bool key = false;
    public static int currentTextBoxNumber;

    public static Vector3 currentPosition;

    public static bool[] killPillExists = { true, true, true };
    public static bool[] doorOpen = { false, false, false };



	// Use this for initialization
	void Start () {
        if(currentPosition == default(Vector3))
        {
            currentPosition.x = 13;
            currentPosition.y = 0;
            currentPosition.z = -13;
        }

    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
