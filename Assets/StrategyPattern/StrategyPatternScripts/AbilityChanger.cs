using UnityEngine;

[RequireComponent(typeof(AbilityRunner))]
public class AbilityChanger : MonoBehaviour
{
    private AbilityRunner m_abilityRunner;

    private void Awake() 
    {
        m_abilityRunner = GetComponent<AbilityRunner>();
    }

    private void Start() 
    {
        m_abilityRunner.CurrentAbility = new FireBallAbility();
    }

    private void Update() 
    {
        IAbility currentAbility = m_abilityRunner.CurrentAbility;

        if (Input.GetKeyDown(KeyCode.Alpha1) && currentAbility is not FireBallAbility)
        {
            m_abilityRunner.CurrentAbility = new FireBallAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && currentAbility is not HealAbility)
        {
            m_abilityRunner.CurrentAbility = new HealAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && currentAbility is not SilentStepAbility)
        {
            m_abilityRunner.CurrentAbility = new SilentStepAbility();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && currentAbility is not MindControlAbility)
        {
            m_abilityRunner.CurrentAbility = new MindControlAbility();
        }
    }
}
