using System; // Added
using System.Collections;
using System.Collections.Generic;
using System.Linq; // Added
using UnityEngine;
using UnityEngine.UI; // Added
using UnityEngine.Events; //Added


public class TapticEngineVibrate : MonoBehaviour
{
public GameObject VibrateIndicator;

    public UnityEvent OnTriggerEnterAction; //Added
    public UnityEvent OnTriggerExitAction; //Added
    public float VibrateIndicatorTimer = 0.2f;

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
            ActivateVibrateIndicator();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Camera.main.gameObject)
        {
            Debug.Log("Out");
            OnTriggerExitAction?.Invoke(); // Added
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

    private void ActivateVibrateIndicator ()
    {
        VibrateIndicator.SetActive(true);
        Invoke("DeactivateVibrateIndicator",VibrateIndicatorTimer);
    }

    private void DeactivateVibrateIndicator ()
    {
        VibrateIndicator.SetActive(false);
    }
}