using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxColi : MonoBehaviour
{
    public string NextPhase;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(NextPhase);
        }
    }
}
