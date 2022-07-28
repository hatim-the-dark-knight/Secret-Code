using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = gameObject.GetComponentInChildren<Text>();
    }

    public void IncrementNoInTheBox ()
    {
        if (text.text == "-")
        {
            text.text = "0";
        }
        else if (text.text == "9")
        {
            text.text = "-";
        }
        else
        {
            text.text = (Convert.ToInt32 (text.text) + 1).ToString ();
        }
    }
}
