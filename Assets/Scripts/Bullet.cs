using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Rigidbody _rb;


    private void FixedUpdate()
    {
        _rb.velocity = transform.forward * 15;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zemin"))
        {
            Destroy(gameObject);
        }
    }
}
