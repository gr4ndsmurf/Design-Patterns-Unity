using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorCreator
{
    //script that creates a random color for us and returns it.
    public static Color CreateRandomColor()
    {
        // unity colors are 0 - 1, instead of 0 - 255
        float randomR = Random.Range(0, 1f);
        float randomG = Random.Range(0, 1f);
        float randomB = Random.Range(0, 1f);
        // alpha default is 0, we need 1 to be opaque
        Color newColor = new Color(randomR, randomG, randomB, 1);

        return newColor;
    }
}
