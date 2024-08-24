using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduct
{
    public string ProductName { get; }

    public void Initialize();
}
