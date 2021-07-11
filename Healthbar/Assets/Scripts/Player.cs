using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _moveX;
    public float _playerHealt = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        _moveX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(
            _moveX * _moveSpeed,
            rb.velocity.y
        );

        if(_playerHealt <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy") {
            TakeDamage();
        }
    }

    private void TakeDamage() {
        _playerHealt -= 20;
    }
}
