using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyboard : MonoBehaviour
{
    [SerializeField] private GameObject buttonGameObject;
    
    public void OpenKeyboardEden()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        buttonGameObject.SetActive(false);
    }
}
