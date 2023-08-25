using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject TrianglePrefab1;
    [SerializeField] private GameObject TrianglePrefab2;

    public const int TRIANGLE_TYPE_1 = 0;
    public const int TRIANGLE_TYPE_2 = 1;

    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case TRIANGLE_TYPE_1:
                var triangle1 = Instantiate(TrianglePrefab1);
                triangle1.transform.position = position;
                return new Triangle1();
            case TRIANGLE_TYPE_2:
                var triangle2 = Instantiate(TrianglePrefab2);
                triangle2.transform.position = position;
                return new Triangle2();
        }

        return null;
    }
}

public class Triangle1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Triangle 1";
    }
}
public class Triangle2 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Triangle 2";
    }
}
