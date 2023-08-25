using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject SquarePrefab1;
    [SerializeField] private GameObject SquarePrefab2;
    [SerializeField] private GameObject SquarePrefab3;

    public const int SQUARE_TYPE_1 = 0;
    public const int SQUARE_TYPE_2 = 1;
    public const int SQUARE_TYPE_3 = 3;

    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case SQUARE_TYPE_1:
                var square1 = Instantiate(SquarePrefab1);
                square1.transform.position = position;
                return new Square1();
            case SQUARE_TYPE_2:
                var square2 = Instantiate(SquarePrefab2);
                square2.transform.position = position;
                return new Square2();
            case SQUARE_TYPE_3:
                var square3 = Instantiate(SquarePrefab3);
                square3.transform.position = position;
                return new Square3();
        }

        return null;
    }
}

public class Square1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Square 1";
    }
}
public class Square2 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Square 2";
    }
}
public class Square3 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Square 3";
    }
}
