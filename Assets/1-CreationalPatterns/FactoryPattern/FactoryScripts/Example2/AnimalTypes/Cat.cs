using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour, IAnimal
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Initialize()
    {
        Debug.Log("Cat Initialized.");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }
}
