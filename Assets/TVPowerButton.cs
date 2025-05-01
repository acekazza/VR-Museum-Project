using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVPowerButton : MonoBehaviour
{
    public GameObject glowingScreen;
    public AudioSource staticAudio;

    private bool isOn = false;

    public void ToggleTV()
    {
        isOn = !isOn;

        if (glowingScreen != null)
            glowingScreen.SetActive(isOn);

        if (staticAudio != null)
        {
            if (isOn && !staticAudio.isPlaying)
                staticAudio.Play();
            else if (!isOn && staticAudio.isPlaying)
                staticAudio.Stop();
        }
    }
}
