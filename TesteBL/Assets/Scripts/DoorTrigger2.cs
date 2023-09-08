using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{
    public static DoorTrigger2 instance;
    
    public bool isPressioned2 = false;
    private void Awake()
    {
        if (instance == this) { 
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        isPressioned2 = true;
    }

    void OnTriggerExit(Collider col)
    {
        isPressioned2 = false;
    }
}
