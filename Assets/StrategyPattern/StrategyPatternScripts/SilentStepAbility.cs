using UnityEngine;

public class SilentStepAbility : IAbility
{
    public void Use()
    {
        Debug.Log("shh, be quiet!");
    }
}
