using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxScript : MonoBehaviour {

    public Text text;
    private bool colliding;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Textbox"))
        {
            colliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Textbox"))
        {
            colliding = false;
        }
    }

 
    void Update () {
		if(colliding)
        {
            /*switch(TextBoxNumber.textBoxNumber2)
            {
                case 0: text.text = "Pick up the red thing to die and become a ghost!\n" +
                                  " Now you can walk through walls! "; break;
                case 1: text.text = "It's closed from the outside."; break;
                default: text.text = ""; break;
            }
            */

            if (GameManager.currentTextBoxNumber == 0)
                text.text = "Pick up the red thing to die and become a ghost!\n" +
                                  " Now you can walk through walls";
            if (GameManager.currentTextBoxNumber == 1)
                text.text = "It's locked from the outside.";
            if (GameManager.currentTextBoxNumber == 2)
                text.text = "Press E to open";
        }
	}
    
}
