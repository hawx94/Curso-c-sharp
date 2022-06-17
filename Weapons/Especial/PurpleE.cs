using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleE : MonoBehaviour
{
    public int damage = 1200;

    private void Start()
    {
      Destroy(gameObject,.5f);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
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
