using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    public int currenthealth, maxHealth;
    public int lifes, extraLife;
    public Slider barHeath;
    public bool player1Dead;

    private void Awake()
    {
        instance = this;

    }



    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        lifes = 3 + extraLife;
        barHeath.maxValue = maxHealth;
         
        barHeath.value = currenthealth;
        player1Dead = false;

    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    public void Health(int damage)
    {
        currenthealth -= damage;
        barHeath.value = currenthealth;

        if (currenthealth <= 0)
        {

            lifes--;
           
            if (lifes > 0)
            {
                currenthealth = maxHealth;
                barHeath.value = maxHealth;
            }

            if(currenthealth <= 0 && lifes <= 0)
            {
                Destroy(gameObject);
                player1Dead = true;
            }

        }

    }
    public void HealthUpp(int up)
    {
        currenthealth += up;
        if(currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
        }
    }

    public void AddLife()
    {
        lifes++;
    }

    public void GameOver()
    {
        if (lifes == 0)
        {
            Debug.Log("MORRI");
        }
    }
}
