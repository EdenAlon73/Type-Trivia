using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtFieldChanger : MonoBehaviour
{
    [SerializeField]private KeyboardScript keyboardScript;
    [SerializeField] private InputField inputField;
    [SerializeField] private InputField inputField2;
    [SerializeField] private Image first;
    [SerializeField] private Image second;
    [SerializeField] private Color red;
    [SerializeField] private Color green;
    private bool gotFirstWord = false;
    private bool started = false;
    private void Update()
    {
        GotFieldRight();
        ChangeColor();
    }
    private void GotFieldRight()
    {
        if (inputField.text.Equals("s"))
        {
            started = true;
            gotFirstWord = true;
            ChangeField();
            ChangeColor();
        }
      
        if (inputField.text.Length > 0)
        {
            started = true;
        }

      
    }

    private void ChangeField()
    {
        if (keyboardScript.TextField == inputField)
        {
            keyboardScript.TextField = inputField2;
        }
    }
    private void ChangeColor()
    {
        if (started)
        {
            if (!gotFirstWord)
            {
                first.color = red;
            }
            else
            {
                first.color = green;
            }
        }
        /*
        if (Input.anyKeyDown)
        {
            print("anykey");
            //PaintIt();

            if (!firstB)
            {

                if (Input.GetKeyDown(KeyCode.A))
                {
                    print("gotRightKey");
                    first.color = green;

                    firstB = true;
                }
                else
                {
                    first.color = red;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.B))
                {
                    print("gotRightKey");
                    second.color = green;
                }
                else
                {
                    second.color = red;
                }
            }
        }*/
    }
}
