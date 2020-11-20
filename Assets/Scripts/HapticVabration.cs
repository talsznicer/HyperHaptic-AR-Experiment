using System; // Added
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
    }

    public void TapCancelVibrate ()
    {

        Vibration.Cancel ();
    }

    public void TapPopVibrate ()
    {
        Vibration.VibratePop ();
    }

    public void TapPeekVibrate ()
    {
        Vibration.VibratePeek ();
    }

    public void TapNopeVibrate ()
    {
        Vibration.VibrateNope ();
    }
}
