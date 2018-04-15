using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxNumber : MonoBehaviour {

    public int textBoxNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.currentTextBoxNumber = textBoxNumber;
        }
    }

}
