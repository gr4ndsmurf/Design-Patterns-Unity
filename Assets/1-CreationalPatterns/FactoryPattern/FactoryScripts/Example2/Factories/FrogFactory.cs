using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogFactory : Factory
{
    [SerializeField] private Frog frogPrefab;
    public override IAnimal CreateAnimal(Vector3 position)
    {
        GameObject frogInstance = Instantiate(frogPrefab.gameObject, position, Quaternion.identity);
        Frog newFrog = frogInstance.GetComponent<Frog>();

        newFrog.Initialize();
        newFrog.MakeSound();

        return newFrog;
    }
}
