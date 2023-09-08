using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger6 : MonoBehaviour
{
    public static DoorTrigger6 instance;
    
    public bool isPressioned6 = false;
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
        isPressioned6 = true;
    }

    void OnTriggerExit(Collider col)
    {
        isPressioned6 = false;
    }
}
