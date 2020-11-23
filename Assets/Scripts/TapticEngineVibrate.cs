using System; // Added
using System.Collections;
using System.Collections.Generic;
using System.Linq; // Added
using UnityEngine;
using UnityEngine.UI; // Added
using UnityEngine.Events; //Added

public class TapticEngineVibrate : MonoBehaviour
{
    public UnityEvent OnTriggerEnterAction; //Added

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
            OnTriggerEnterAction?.Invoke(); // Added
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Camera.main.gameObject)
        {
            Debug.Log("Out");
            // TapCancelVibrate ();
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
        Debug.Log("Cancel");
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
