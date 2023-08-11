using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActiveToggle : ICommand
{
    //An example Command for our object that SetActive(true) and SetActive(false).

    GameObject _gameObject = null;

    public ObjectActiveToggle(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    public void Execute()
    {
        Debug.Log("Toggle on/off state");
        _gameObject.SetActive(!_gameObject.activeSelf);
    }

    public void Undo()
    {
        Debug.Log("Undo: toggle back to other state");
        _gameObject.SetActive(!_gameObject.activeSelf);
    }
}
