using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public void PlaySound(string name)
    {
        AudioManager.Instance.Play(name);
    }
}
