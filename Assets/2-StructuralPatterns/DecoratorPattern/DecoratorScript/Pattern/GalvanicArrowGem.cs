using UnityEngine;

// Concrete Component class which implements the IGem interface
public class GalvanicArrowGem : IGem
{
    // field to store the value of the gem
    private readonly int value;
    
    // Constructor to initialize the value of the gem
    public GalvanicArrowGem(int value)
    {
        this.value = value;
    }
    
    // Method to use the gem and return its value
    public int UseGem()
    {
        return value;
    }
}
