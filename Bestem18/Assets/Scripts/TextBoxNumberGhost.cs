using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxNumberGhost : MonoBehaviour {

    public int textBoxNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TextBoxManager.currentTextBoxNumberGhost = textBoxNumber;
        }
    }
}
