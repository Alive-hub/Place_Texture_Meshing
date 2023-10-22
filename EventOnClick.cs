using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnClick : MonoBehaviour
{
    public static event Action buttonToggle;  
    // Start is called before the first frame update

    public void InvokeButtonToggle()
    {
        buttonToggle?.Invoke();
    }
}
