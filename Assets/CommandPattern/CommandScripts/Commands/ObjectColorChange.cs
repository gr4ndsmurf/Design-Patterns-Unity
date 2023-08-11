using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChange : ICommand
{
    //Example of a command for the object. We assign a new color to the light, and change it back when we're done.

    GameObject _gameObject;
    Color _originalColor;
    Color _newColor;

    public ObjectColorChange(GameObject gameObject, Color newColor)
    {
        _gameObject = gameObject;
        _originalColor = gameObject.GetComponent<SpriteRenderer>().color;
        _newColor = newColor;
    }
    public void Execute()
    {
        Debug.Log("Assigned new color: " + _newColor);
        _gameObject.GetComponent<SpriteRenderer>().color = _newColor;
    }

    public void Undo()
    {
        Debug.Log("Undo: Assigned back to original color: " + _originalColor);
        _gameObject.GetComponent<SpriteRenderer>().color = _originalColor;
    }
}
