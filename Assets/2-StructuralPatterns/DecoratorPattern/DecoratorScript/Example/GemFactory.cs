//Static class for creating gem by their type
public static class GemFactory
{
    public static IGem CreateGem (GemTypeSO gemType)
    {
        return gemType.type switch
        {
            GemType.FireDamage => new FireDamageDecorator(gemType.value),
            GemType.ColdDamage => new ColdDamageDecorator(gemType.value),
            _ => new GalvanicArrowGem(gemType.value)
        };
    }
}
