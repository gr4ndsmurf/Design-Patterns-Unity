using UnityEngine;

//Decorator class for adding extra damage functionality to the gem.
public class FireDamageDecorator : GemDecorator
{
    public FireDamageDecorator(int value) : base(value) {}
    
    //Use the decorated gem using the "null-coalescing" operator
    public override int UseGem()
    {
        Debug.Log("Using FireDamageDecorator Gem with value: " + value);
        DamageBuff();
        return gem?.UseGem() ?? 0; 
    }

    //TODO LATER
    private void DamageBuff()
    {
        // DAMAGE BUFF
    }
}
