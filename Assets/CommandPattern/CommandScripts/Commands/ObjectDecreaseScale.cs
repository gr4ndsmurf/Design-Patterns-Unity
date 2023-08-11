using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDecreaseScale : ICommand
{
    float _decreaseAmount = 1.5f;
    GameObject _gameObject;

    public ObjectDecreaseScale(GameObject gameObject)
    {
        _gameObject = gameObject;
    }
    public void Execute()
    {
        Debug.Log("Decrease Scale by: " + _decreaseAmount);
        _gameObject.transform.localScale /= _decreaseAmount;
    }

    public void Undo()
    {
        Debug.Log("Undo: Decrease Scale by: " + _decreaseAmount);
        _gameObject.transform.localScale *= _decreaseAmount;
    }
}
