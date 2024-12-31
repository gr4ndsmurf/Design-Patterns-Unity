using UnityEngine;

public class ColdDamageDecorator : GemDecorator
{
    public ColdDamageDecorator(int value) : base(value) {}
    
    //Use the decorated gem using the "null-coalescing" operator
    public override int UseGem()
    {
        Debug.Log("Using ColdDamageDecorator Gem with value: " + value);
        DamageBuff();
        return gem?.UseGem() ?? 0; 
    }

    //TODO LATER
    private void DamageBuff()
    {
        // DAMAGE BUFF
    }
}
