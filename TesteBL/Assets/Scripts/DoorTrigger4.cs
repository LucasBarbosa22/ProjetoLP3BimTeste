using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger4 : MonoBehaviour
{
    public static DoorTrigger4 instance;
    
    public bool isPressioned4 = false;
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
        isPressioned4 = true;
    }

    void OnTriggerExit(Collider col)
    {
        isPressioned4 = false;
    }
}
