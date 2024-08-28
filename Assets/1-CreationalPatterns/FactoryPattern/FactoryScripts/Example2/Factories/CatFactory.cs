using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFactory : Factory
{
    [SerializeField] private Cat catPrefab;
    public override IAnimal CreateAnimal(Vector3 position)
    {
        GameObject catInstance = Instantiate(catPrefab.gameObject, position, Quaternion.identity);
        Cat newCat = catInstance.GetComponent<Cat>();

        newCat.Initialize();
        newCat.MakeSound();

        return newCat;
    }
}
