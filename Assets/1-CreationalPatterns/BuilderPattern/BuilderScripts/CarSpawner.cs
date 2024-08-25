using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;

    private void Start()
    {
        new CarBuilder().WithSprite(sprites[1]).WithSpeed(6f).Build();
        new CarBuilder().WithSprite(sprites[1]).WithColor(Color.red).WithName("Red Car").WithPosition(new Vector3(-5,1.5f,0)).Build();
        new CarBuilder().WithSprite(sprites[2]).WithColor(Color.blue).WithName("Blue Car").WithPosition(new Vector3(5, 1.5f, 0)).Build();
    }
}
