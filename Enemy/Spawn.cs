using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform asteroids, enemys, bossPosition;
    public GameObject[] enemysPrefab;
    public GameObject[] asteroidsPrefab;
    private float enemyCounter = 10f, asteroidCounter = 15f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        SpawnAsteroid();
    }

    public void SpawnAsteroid()
    {
        asteroidCounter -= Time.deltaTime;
        if (asteroidCounter < 0)
        {
            int randomAsteroid = Random.Range(0, asteroidsPrefab.Length);
            Instantiate(asteroidsPrefab[randomAsteroid], asteroids.position, asteroids.rotation);
            asteroidCounter = 15f;
        }
        
    }

    public void SpawnEnemy()
    {
        enemyCounter -= Time.deltaTime;
        if(enemyCounter <= 0)
        {
            int randomEnemy = Random.Range(0, enemysPrefab.Length);
            Instantiate(enemysPrefab[randomEnemy], enemys.position, enemys.rotation);
            enemyCounter = 10f;
        }
        
    }

    
}
