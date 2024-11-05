using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerWalk : RunnerState
{
    public RunnerRun run;
    public RunnerIdle idle;

    public override RunnerState RunState(RunnerController controller)
    {
        if (!Input.GetKey(KeyCode.W))
        {
            controller.animator.SetBool("Walk", false);
            return idle;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.animator.SetBool("Run", true);
            return run;
        }

        controller.rb.linearVelocity = new Vector2(1f * controller.speed * Time.deltaTime, controller.rb.linearVelocity.y);

        return this;
    }
}
