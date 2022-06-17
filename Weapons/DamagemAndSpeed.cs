using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagemAndSpeed : MonoBehaviour
{
    public PlayerBullet pb;
    public float speed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = pb.damage;
        speed = pb.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); 
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "AstCrystal")
        {
            collision.gameObject.GetComponent<AsteroidHealthAndDamage>().MinusVida(damage);
            Destroy(gameObject);
        }else if (collision.tag == "AstComum")
        {
            collision.gameObject.GetComponent<AstComum>().MinusVida(damage);
            Destroy(gameObject);
        }else if(collision.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealth>().EnemyDamage(damage);
            Destroy (gameObject);
        }else if(collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<Boss>().LifeBoss(damage);
            Destroy(gameObject);
        }
    }
}
