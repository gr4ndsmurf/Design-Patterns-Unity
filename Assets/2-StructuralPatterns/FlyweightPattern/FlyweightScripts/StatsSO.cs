using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stats", menuName = "Flyweight/Stats/Entity Stats")]
public class StatsSO : ScriptableObject
{
    [SerializeField] int _maxHealth = 100;
    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] int _maxDamage = 100;

    public int MaxHealth => _maxHealth;
    public int MaxDamage => _maxDamage;
    public float MoveSpeed => _moveSpeed;
}
