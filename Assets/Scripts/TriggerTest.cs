using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
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
}
