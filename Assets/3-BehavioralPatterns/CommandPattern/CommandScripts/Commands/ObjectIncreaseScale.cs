using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIncreaseScale : ICommand
{
    float _increaseAmount = 1.5f;
    GameObject _gameObject;

    public ObjectIncreaseScale(GameObject gameObject)
    {
        _gameObject = gameObject;
    }
    public void Execute()
    {
        Debug.Log("Increase Scale by: " + _increaseAmount);
        _gameObject.transform.localScale *= _increaseAmount;
    }

    public void Undo()
    {
        Debug.Log("Undo: Increase Scale by: " + _increaseAmount);
        _gameObject.transform.localScale /= _increaseAmount;
    }
}
