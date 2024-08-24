using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is used to test our Command Stack functionality.
// You can use key inputs to execute commands through the Command Stack
// Command Stack tracks history, so Undo button will undo our last command

public class ObjectController : MonoBehaviour
{
    // Object in the scene to send commands to
    [SerializeField] GameObject _gameObject = null;

    [Header("Inputs")]
    [SerializeField] KeyCode _toggleKey = KeyCode.Alpha1;
    [SerializeField] KeyCode _increaseScaleKey = KeyCode.Alpha2;
    [SerializeField] KeyCode _decreaseScaleKey = KeyCode.Alpha3;
    [SerializeField] KeyCode _randomColorKey = KeyCode.Alpha4;
    [SerializeField] KeyCode _undoCommandKey = KeyCode.Z;

    CommandStack _commandStack = new CommandStack();

    private void Update()
    {
        DetectToggleInput();
        DetectIncreaseScaleInput();
        DetectDecreaseScaleInput();
        DetectRandomColorInput();

        DetectUndoInput();
    }

    private void DetectToggleInput()
    {
        if (Input.GetKeyDown(_toggleKey))
        {
            _commandStack.ExecuteCommand
                (new ObjectActiveToggle(_gameObject));
        }
    }

    private void DetectIncreaseScaleInput()
    {
        if (Input.GetKeyDown(_increaseScaleKey))
        {
            _commandStack.ExecuteCommand
                (new ObjectIncreaseScale(_gameObject));
        }
    }

    private void DetectDecreaseScaleInput()
    {
        if (Input.GetKeyDown(_decreaseScaleKey))
        {
            _commandStack.ExecuteCommand
                (new ObjectDecreaseScale(_gameObject));
        }
    }

    private void DetectRandomColorInput()
    {
        if (Input.GetKeyDown(_randomColorKey))
        {
            Color randomColor = ColorCreator.CreateRandomColor();
            _commandStack.ExecuteCommand
                (new ObjectColorChange(_gameObject, randomColor));
        }
    }

    private void DetectUndoInput()
    {
        if (Input.GetKeyDown(_undoCommandKey))
        {
            // undo previous action
            _commandStack.UndoLastCommand();
        }
    }
}
