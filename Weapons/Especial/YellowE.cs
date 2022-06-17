using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowE : MonoBehaviour
{
    public GameObject explosionPS;
    private int damage;
    public Rigidbody2D theRB;
    private bool explode;
    public float speed;
    
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();      
        explode = false;
        damage = 0;
    }

    
    void Update()
    {
        transform.position += speed * Time.deltaTime * transform.up;
        Move();
        Explosion();
    }


    public void Explosion()
    {
        if (explode)
        {
            damage = 1200;
            Instantiate(explosionPS,transform.position,transform.rotation);
            Destroy(gameObject);
        }
        

    }

    public void Move()
    {
        if(speed >= 0)
        {
            speed -= 2f * Time.deltaTime;
        }
        else
        {
            
            speed = 0;
            explode = true;
            
          

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().EnemyDamage(damage);
            Debug.Log("Hit");
        }
        else if (collision.CompareTag("AstCrystal"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
            Debug.Log("Hit");
        }
        else if (collision.CompareTag("AstComum"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
            Debug.Log("Hit");
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LifeBoss(damage);
        }
    }
}
