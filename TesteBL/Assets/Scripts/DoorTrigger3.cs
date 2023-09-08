using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger3 : MonoBehaviour
{
    public static DoorTrigger3 instance;
    
    public bool isPressioned3 = false;
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
        isPressioned3 = true;
    }

    void OnTriggerExit(Collider col)
    {
        isPressioned3 = false;
    }
}
