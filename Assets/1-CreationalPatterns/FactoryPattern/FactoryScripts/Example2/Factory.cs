using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public abstract IAnimal CreateAnimal(Vector3 position);
}
