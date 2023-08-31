using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrueVerify : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject door2;

    bool isOpened = false;

    Animator doorAnimator;
    Animator door2Animator;

    private void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
        door2Animator = door2.GetComponent<Animator>();
    }

    private void Update()
    {
        verififyPressure();
    }
    void verififyPressure()
    {
        if (isOpened == false && (DoorTrigger.instance.isPressioned1 == true && DoorTrigger2.instance.isPressioned2 == true))
        {
            isOpened = true;
            doorAnimator.Play("OpenDoor", 0, 0.0f);
            door2Animator.Play("OpenDoor2", 0, 0.0f);
        }
        else if(isOpened == true && (DoorTrigger.instance.isPressioned1 == false || DoorTrigger2.instance.isPressioned2 == false))
        {
            isOpened = false;
            doorAnimator.Play("CloseDoor", 0, 0.0f);
            door2Animator.Play("CloseDoor2", 0, 0.0f);
        }
    }
}
