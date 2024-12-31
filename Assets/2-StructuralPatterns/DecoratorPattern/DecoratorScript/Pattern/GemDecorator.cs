using UnityEngine;

// Abstract Decorator class for adding extra functionality to the main gem (Galvanic Arrow Gem)
public abstract class GemDecorator : IGem
{
    protected IGem gem; // The gem being decorated
    protected readonly int value; // The value added by the decorator


    // Constructor to initialize the decorator's value
    public GemDecorator(int value)
    {
        this.value = value;
    }


    // Method to decorate a gem
    public void Decorate(IGem gem)
    {
        // Prevent self-decoration
        if(ReferenceEquals(this, gem))
        {
            Debug.LogWarning("Gem can't decorate itself.");
            return;
        }

        // If the current gem is a decorator, pass the decoration down the chain
        if(this.gem is GemDecorator decorator)
        {
            decorator.Decorate(gem);
        }
        else
        {
            // Set the gem to be decorated
            this.gem = gem;
        }
    }

    // Method to use the gem, adding the decorator's value with "null-coalescing" operator
    public virtual int UseGem()
    {
        Debug.Log("Using Decorator Gem with value: " + value);
        return gem?.UseGem() + value ?? value;
    }
}
