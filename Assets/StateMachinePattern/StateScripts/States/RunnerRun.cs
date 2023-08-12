using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerRun : RunnerState
{
    public RunnerWalk walk;

    public override RunnerState RunState(RunnerController controller)
    {
        if (!Input.GetKey(KeyCode.LeftShift) || !Input.GetKey(KeyCode.W))
        {
            controller.animator.SetBool("Walk", true);
            controller.animator.SetBool("Run", false);
            return walk;
        }

        controller.rb.velocity = new Vector2(1f * controller.speed * 2 * Time.deltaTime, controller.rb.velocity.y);

        return this;
    }
}
