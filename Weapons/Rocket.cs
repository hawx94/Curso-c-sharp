using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public int damage, speed, speedATK;
    public GameObject target = null;
    public bool tgtOn;
    public Rigidbody2D theRB;
    



    
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        tgtOn = false;
    }

    
    void Update()
    {
        AutoDestroy();
        Move();
    }

    private void FixedUpdate()
    {
       
    }

    public void AutoDestroy()
    {
        if(target == null && tgtOn)
        {
            Destroy(gameObject);
        }
    }

    public void Move()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (tgtOn)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speedATK * Time.deltaTime);
            Vector3 lookDirection = target.transform.position - transform.position;
            float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            theRB.rotation = lookAngle;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Boss"))
        {
            target = collision.gameObject;
            tgtOn = true;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().EnemyDamage(damage);
            Debug.Log("Hit");
        }
        else if (collision.gameObject.CompareTag("AstCrystal"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
        }
        else if (collision.gameObject.CompareTag("AstComum"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
        }else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LifeBoss(damage);
        }

        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
