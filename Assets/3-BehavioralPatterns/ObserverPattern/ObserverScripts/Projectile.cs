using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class Projectile : MonoBehaviour
{
    [SerializeField] float _travelSpeed = 1f;
    [SerializeField] int _damage = 20;

    Rigidbody2D _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Travel(_rb);
    }

    protected void Travel(Rigidbody2D rb)
    {
        Vector2 moveOffset = Vector2.up * _travelSpeed;
        rb.MovePosition(rb.position + moveOffset * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        health?.TakeDamage(_damage);
        //TODO consider Object Pooling here!
        Destroy(gameObject);
    }
}

