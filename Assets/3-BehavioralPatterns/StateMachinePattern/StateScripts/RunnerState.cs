using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RunnerState : MonoBehaviour
{
    public abstract RunnerState RunState(RunnerController controller);
}
