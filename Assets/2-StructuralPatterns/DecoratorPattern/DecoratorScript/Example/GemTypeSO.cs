using UnityEngine;

[CreateAssetMenu(fileName = "Gems", menuName = "Gems/New Gem")]
public class GemTypeSO : ScriptableObject
{
    public int value;
    public GemType type;
}

public enum GemType{
    GalvanicArrow,
    ColdDamage,
    FireDamage
}
