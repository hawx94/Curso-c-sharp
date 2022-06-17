using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillEspecialAndRocket : MonoBehaviour
{
    public static RefillEspecialAndRocket Instance;
    public int up = 50;

    private void Awake()
    {
        Instance = this;
    }
    public enum RefillType
    {
        rocket,
        especial,
        lifes,
        health
    }

    public RefillType type;

    public void Refill()
    {
        if(type == RefillType.rocket)
        {
            ActionOfFire.instance.AddRocket();
            FirePlayer2.instance.AddRocket();
        }
        else if(type == RefillType.especial)
        {
             ActionOfFire.instance.AddSpecial();
             FirePlayer2.instance.AddSpecial();
        }
        else if(type == RefillType.lifes)
        {
            PlayerHealth.instance.AddLife();
            Player2Health.instance.AddLife();
        }
        else if (type == RefillType.health)
        {
            PlayerHealth.instance.HealthUpp(up);
            Player2Health.instance.HealthUpp(up);
        }
    }

    

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Refill();
            Destroy(gameObject);

        }
    }
}
