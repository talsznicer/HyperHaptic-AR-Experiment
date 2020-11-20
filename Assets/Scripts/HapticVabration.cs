﻿using System; // Added
using System.Collections;
using System.Collections.Generic;
using System.Linq; // Added
using UnityEngine;
using UnityEngine.UI; // Added

public class HapticVabration : MonoBehaviour
{
     // Use this for initialization
    void Start ()
    {
        Vibration.Init ();
        Debug.Log ( "Application.isMobilePlatform: " + Application.isMobilePlatform );
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Camera.main.gameObject)
        {
            Debug.Log("In");
            TapVibrate ();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Camera.main.gameObject)
        {
            Debug.Log("Out");
        }
    }

    public void TapVibrate ()
    {
        Vibration.Vibrate ();
        Debug.Log("Vibrate");
    }

    public void TapCancelVibrate ()
    {
        Vibration.Cancel ();
    }

    public void TapPopVibrate ()
    {
        Vibration.VibratePop ();
        Debug.Log("PopVibrate");
    }

    public void TapPeekVibrate ()
    {
        Vibration.VibratePeek ();
        Debug.Log("PeekVibrate");
    }

    public void TapNopeVibrate ()
    {
        Vibration.VibrateNope ();
        Debug.Log("NopeVibrate");
    }
}