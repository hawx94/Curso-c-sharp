using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobustSpawn : MonoBehaviour
{
    public GameObject[] lv1,lv2, lv3;
    public Transform[] p1;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5f * 60f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
       while(timer > 0)
        {
            Spawn();
        }
        
    }

    public void Spawn()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine("SpawnX");
        }
        
    }

    IEnumerator SpawnX()
    {
        for (int i = 0; i < lv1.Length; i++)
        {
            int x = Random.Range(1, p1.Length);
            yield return new WaitForSeconds(1f);
            Instantiate(lv1[i], p1[x].position, p1[x].rotation);
            yield return new WaitForSeconds(1f);
        }
        
    }

}
