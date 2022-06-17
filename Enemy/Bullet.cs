using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public EnemyBullet enemyBullet;

    private int _speed, _damage;
    // Start is called before the first frame update
    void Start()
    {
        _speed = enemyBullet.speed;
        _damage = enemyBullet.damage;
    }

    private void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
                collision.gameObject.GetComponent<PlayerHealth>().Health(_damage);
             
            
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Player2"))
        {
                       
                collision.gameObject.GetComponent<Player2Health>().Health(_damage);
            

            Destroy(gameObject);
        }


    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
