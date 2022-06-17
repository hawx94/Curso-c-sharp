using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public EnemySkills skills;
    private int health;
    private int impactDamage;
    public GameObject  healthRefill, lifesRefill;
    private float _timeToShoot;
    
    // Start is called before the first frame update
    private void Start()
    {
        health = skills.health;
        impactDamage = skills.damage;
        _timeToShoot = skills.timeToShoot;
    }

   
    private void FixedUpdate()
    {
        Fire();
    }

    public void EnemyDamage(int dano)
    {
        health -= dano/2;
        if (health <= 0)
        {
            int h = Random.Range(1, 10);
            int l = Random.Range(1, 10);
            if(h < 2)
            {
                Instantiate(healthRefill, transform.position, transform.rotation);
            }

            if(l < 2)
            {
                Instantiate(lifesRefill, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }

    public void Fire()
    {
       _timeToShoot -= Time.deltaTime;
        if(_timeToShoot < 0)
        {
            Instantiate(skills.bullet, transform.position, transform.rotation);
            _timeToShoot = skills.timeToShoot;
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponentInParent<PlayerHealth>().Health(impactDamage);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponentInParent<PlayerHealth>().Health(impactDamage);
        }
    }
}
