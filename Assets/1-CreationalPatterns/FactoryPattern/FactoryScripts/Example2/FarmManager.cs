using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Factory[] factories;

    private Factory factory;

    private void Update()
    {
        SpawnAnimalOnClick();
    }

    private void SpawnAnimalOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            factory = factories[Random.Range(0, factories.Length)];

            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (factory != null)
            {
                factory.CreateAnimal(pos + offset);
            }
        }
    }
}
