using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip clip;
    public string name;
    [Range(0, 1)] public float volume;
    [Range(0, 3)] public float pitch;
    [HideInInspector] public AudioSource audioSource;
    public bool loop;
}