using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerStateMachine : MonoBehaviour
{
    public RunnerState currentState;
    public RunnerController controller;


    private void Start()
    {
        controller = GetComponent<RunnerController>();
    }

    private void Update()
    {
        RunnerState state = currentState.RunState(controller);
        if (currentState != null)
        {
            currentState = state;
        }
    }
}
