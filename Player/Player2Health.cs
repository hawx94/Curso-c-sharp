using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Health : MonoBehaviour
{
    public static Player2Health instance;
    public int currenthealth, maxHealth;
    public int lifes;
    public Slider barHeath;
    public bool player2Dead;

    private void Awake()
    {
        instance = this;

    }



    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        lifes = 3 ;
        barHeath.maxValue = maxHealth;

        barHeath.value = currenthealth;
        player2Dead = false;

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

            if (currenthealth <= 0 && lifes <= 0)
            {
                Destroy(gameObject);
                player2Dead = true;
            }

        }

    }
    public void HealthUpp(int up)
    {
        currenthealth += up;
        if (currenthealth > maxHealth)
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
