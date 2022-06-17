using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstComum : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] int damage;
    public GameObject droped ;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Die", false);
    }

    // Update is called once per frame
    void Update()
    {
        Explode();
    }

    public void MinusVida(int hurt)
    {
        vida -= hurt;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().Health(damage);
        }
    }

    public void Explode()
    {
        if (vida <= 0)
        {
            anim.SetBool("Die", true);
            int x = Random.Range(1, 10);
            if (x < 5)
            {
                Instantiate(droped, transform.position, transform.rotation);
            }
            
            Destroy(gameObject);
        }
    }
}
