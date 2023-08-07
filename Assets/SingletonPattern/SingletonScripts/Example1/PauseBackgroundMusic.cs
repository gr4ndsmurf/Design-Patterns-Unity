using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBackgroundMusic : MonoBehaviour
{
    public void StopMusic()
    {
        BackgroundMusic.instance.gameObject.GetComponent<AudioSource>().Pause();
    }

    public void StartMusic()
    {
        BackgroundMusic.instance.gameObject.GetComponent<AudioSource>().UnPause();
    }
}
