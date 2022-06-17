using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedE : MonoBehaviour
{
    int damage = 5;
    public GameObject fireEffct;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(fireEffct,transform.position,Quaternion.identity);
        Destroy(gameObject,6f);
    }

   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().EnemyDamage(damage);
        }else if (collision.CompareTag("AstCrystal"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
        }
        else if (collision.CompareTag("AstComum"))
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LifeBoss(damage);

        }

    }
}
