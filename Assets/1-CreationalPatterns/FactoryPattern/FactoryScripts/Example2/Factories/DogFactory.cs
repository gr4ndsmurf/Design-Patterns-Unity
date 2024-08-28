using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFactory : Factory
{
    [SerializeField] private Dog dogPrefab;
    public override IAnimal CreateAnimal(Vector3 position)
    {
        GameObject dogInstance = Instantiate(dogPrefab.gameObject, position, Quaternion.identity);
        Dog newDog = dogInstance.GetComponent<Dog>();

        newDog.Initialize();
        newDog.MakeSound();

        return newDog;
    }
}
