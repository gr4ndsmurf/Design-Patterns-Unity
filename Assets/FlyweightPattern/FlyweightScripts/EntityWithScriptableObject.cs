using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityWithScriptableObject : BaseEntity
{
  /*The Flyweight Pattern is a design pattern used in software development to optimize the use of memory and resources
    when dealing with a large number of objects with similar properties.
    It is primarily focused on reducing the memory footprint of an application 
    by sharing common data between multiple objects instead of storing duplicate data for each object.*/

    [SerializeField] StatsSO stats;
    void Start()
    {
        _currentHealth = Random.Range(25, stats.MaxHealth);
        _currentDamage = Random.Range(25, stats.MaxDamage);
    }

}
