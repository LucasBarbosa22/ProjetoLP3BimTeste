using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControler : MonoBehaviour
{
    private bool soundState = true;
    [SerializeField] private AudioSource backgroundSound;

    [SerializeField] private Sprite soundOn;
    [SerializeField] private Sprite soundOff;

    [SerializeField] private Image muteImage;

    public void TurnOnoFFSound()
    {
        soundState = !soundState;
        backgroundSound.enabled = soundState;

        if(soundState)
        {
            muteImage.sprite = soundOn;
        }
        else
        {
            muteImage.sprite = soundOff;
        }
    }

    public void musicVolume(float value)
    {
        backgroundSound.volume = value;
    }
}
