using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    private IAbility m_currentAbility;
    public IAbility CurrentAbility
    {
        get => m_currentAbility;
        set => m_currentAbility = value;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_currentAbility.Use();
        }
    }
}
