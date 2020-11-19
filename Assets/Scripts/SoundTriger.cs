using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriger : MonoBehaviour
{
public AudioSource audioSource;

void Start()
{ 
          audioSource.enabled = false;
          Debug.Log("Noise off");
}

private void OnTriggerEnter(Collider other)
{
    if(other.gameObject == Camera.main.gameObject)
    {
        Debug.Log("In");
        audioSource.enabled = true;
    }
}

private void OnTriggerExit(Collider other)
{
    if (other.gameObject == Camera.main.gameObject)
    {
        Debug.Log("Out");
        audioSource.enabled = false;
    }
}
}