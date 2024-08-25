using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBuilder
{
    private Sprite _sprite;
    private Color _color = Color.white;
    private SpriteRenderer _spriteRenderer;
    private float _speed = 3f;
    private Vector3 _position = new Vector3(0,-3,0);
    private Quaternion _rotation = Quaternion.identity;
    private string _carName = "WhiteCar";

    private readonly Car _car;


    public CarBuilder()
    {
        _car = new GameObject().AddComponent<Car>();
    }

    public CarBuilder WithSpeed(float speed)
    {
        _speed = speed;
        return this;
    }

    public CarBuilder WithPosition(Vector3 position)
    {
        _position = position;
        return this;
    }

    public CarBuilder WithRotation(Quaternion rotation)
    {
        _rotation = rotation;
        return this;
    }

    public CarBuilder WithSprite(Sprite sprite)
    {
        _sprite = sprite;
        return this;
    }

    public CarBuilder WithColor (Color color)
    {
        _color = color;
        return this;
    }

    public CarBuilder WithName (string carName)
    {
        _carName = carName;
        return this;
    }

    public Car Build()
    {
        _car.Speed = _speed;
        _car.transform.position = _position;
        _car.transform.rotation = _rotation;
        _spriteRenderer = _car.gameObject.AddComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _sprite;
        _spriteRenderer.color = _color;
        _car.gameObject.name = _carName;
        return _car;
    }
}
