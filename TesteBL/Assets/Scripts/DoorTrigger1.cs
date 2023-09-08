using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public static DoorTrigger instance;

    public bool isPressioned1 = false;
    private void Awake()
    {
        if (instance == this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        isPressioned1 = true;
    }

    void OnTriggerExit(Collider col)
    {
        isPressioned1 = false;
    }
}
