using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerIdle : RunnerState
{
    public RunnerWalk walk;

    public override RunnerState RunState(RunnerController controller)
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.animator.SetBool("Walk", true);
            return walk;
        }

        controller.rb.linearVelocity = new Vector2(0f, controller.rb.linearVelocity.y);
        return this;
    }
}
