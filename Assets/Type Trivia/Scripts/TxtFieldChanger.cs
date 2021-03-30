using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtFieldChanger : MonoBehaviour
{
    [SerializeField]private KeyboardScript keyboardScript;
    [SerializeField] private InputField inputField;
    [SerializeField] private InputField inputField2;
    [SerializeField] private InputField inputField3;
    [SerializeField] private Image first;
    [SerializeField] private Image second;
    [SerializeField] private Image third;
    [SerializeField] private Color red;
    [SerializeField] private Color green;
    [SerializeField] private string latterToGuess = "s";
    [SerializeField] private string latterToGuess2 = "a";
    [SerializeField] private string latterToGuess3 = "y";
    private bool gotFirstWord = false;
    private bool gotSecondWord = false;
    private bool gotThirdWord = false;
    private bool started = false;
    private bool started2 = false;
    private bool started3 = false;
    private bool onSecondField = false;
    private bool onThirdField = false;
    private void Update()
    {
        GotFieldRight();
        ChangeColor();
    }
    private void GotFieldRight()
    {
        if (inputField.text.Equals(latterToGuess))
        {
            if (!gotFirstWord)
            {
                gotFirstWord = true;
                ChangeField();
            }
        }
      
        if (inputField.text.Length > 0)
        {
            started = true;
        }

        if (inputField2.text.Equals(latterToGuess2))
        {
            gotSecondWord = true;
            ChangeField();
        }
        if(inputField2.text.Length > 0)
        {
            started2 = true;
        }

        if (inputField3.text.Equals(latterToGuess3))
        {
            gotThirdWord = true;
        }
        if(inputField3.text.Length > 0)
        {
            started3 = true;
        }
   
    }

    private void ChangeField()
    {
        if (keyboardScript.TextField == inputField)
        {
            keyboardScript.TextField = inputField2;
            onSecondField = true;
            print("Changing Field");
        }
        if (gotSecondWord)
        {
            if (keyboardScript.TextField == inputField2)
            {
                keyboardScript.TextField = inputField3;
                onThirdField = true;
                print("ya Changing Field");
            }
        }
    }
    private void ChangeColor()
    {
        if (started)
        {
            
                if (!gotFirstWord)
                {
                    first.color = red;
                    inputField.Select();
                    inputField.text = "";
                }
                else
                {
                    first.color = green;
                }

            if (onSecondField)
            {
                if (started2)
                {

                    if (!gotSecondWord)
                    {
                        second.color = red;
                        inputField2.Select();
                        inputField2.text = "";
                    }
                    else
                    {
                        second.color = green;
                    }
                }
            }
        }
        if (onThirdField)
        {
            if (started3)
            {
                if (!gotThirdWord)
                {
                    third.color = red;
                    inputField3.Select();
                    inputField3.text = "";
                }
                else
                {
                    third.color = green;
                }
            }
        }
       
    }
}
