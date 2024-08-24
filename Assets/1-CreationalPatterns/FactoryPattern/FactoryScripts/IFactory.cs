using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFactory
{
    public IProduct GetProduct(int productType, Vector3 position);
}
