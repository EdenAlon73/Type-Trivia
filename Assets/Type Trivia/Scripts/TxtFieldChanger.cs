using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtFieldChanger : MonoBehaviour
{
    
    private TouchScreenKeyboard _touchScreenKeyboard;
   
    [SerializeField] private InputField[] inputFields;
    [SerializeField] private string[] lattersToGuess;
    [SerializeField] private Color red;
    [SerializeField] private Color green;
    [SerializeField] private int fieldIndex = 0;
    private bool gotLetterRight = false;
    private bool startedWriting = false;
    
    
    private void Start()
    {
        SelectFirstField();
    }
    private void Update()
    {
        GotFieldRight();
    }
    
    private void GotFieldRight()
    {
        if (inputFields[fieldIndex].text.Equals(lattersToGuess[fieldIndex]))
        {
            gotLetterRight = true;
            ChangeColor();
        }
        else
        {
            gotLetterRight = false;
            if (inputFields[fieldIndex].text.Length > 0)
            {
                startedWriting = true;
                ChangeColor();
            }
        }
    }

    private void ChangeField()
    {
        fieldIndex++;
        SelectNextField();
    }
    private void ChangeColor()
    {
        if (gotLetterRight)
        {
            inputFields[fieldIndex].image.color = green;
            SelectNextField();
            ChangeField();
        }
        else
        {
            if (startedWriting)
            {
                inputFields[fieldIndex].image.color = red;
                inputFields[fieldIndex].text = "";
                startedWriting = false;
            }
        }
        
       
    }

    private void SelectFirstField()
    {
        inputFields[0].ActivateInputField();
    }

    private void SelectNextField()
    {
        if(fieldIndex < inputFields.Length)
        {
            inputFields[fieldIndex].Select();
        }
    }
}
