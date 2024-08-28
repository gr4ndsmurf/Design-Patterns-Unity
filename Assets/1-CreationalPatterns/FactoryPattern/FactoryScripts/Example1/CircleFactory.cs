using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject CirclePrefab1;

    public const int CIRCLE_TYPE_1 = 0;

    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case CIRCLE_TYPE_1:
                var circle1 = Instantiate(CirclePrefab1);
                circle1.transform.position = position;
                return new Circle1();
        }

        return null;
    }
}

public class Circle1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Circle 1";
    }
}
