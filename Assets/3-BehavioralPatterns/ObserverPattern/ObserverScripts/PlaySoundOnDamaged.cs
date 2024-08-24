using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class PlaySoundOnDamaged : MonoBehaviour
{
    [SerializeField] AudioClip _damagedSound = null;
    [SerializeField] AudioClip _killedSound = null;
    [SerializeField] Transform _locationToPlay = null;

    Health _health = null;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.Damaged += OnDamaged;
        _health.Killed += OnKilled;
    }

    private void OnDisable()
    {
        _health.Damaged -= OnDamaged;
        _health.Killed -= OnKilled;
    }

    void OnDamaged(int damage)
    {
        if (_damagedSound != null && _locationToPlay != null)
        {
            AudioSource.PlayClipAtPoint
                (_damagedSound, _locationToPlay.position);
        }
    }

    void OnKilled()
    {
        if (_damagedSound != null && _locationToPlay != null)
        {
            AudioSource.PlayClipAtPoint
                (_killedSound, _locationToPlay.position);
        }
    }
}
