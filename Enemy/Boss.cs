using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public BossSkills bossSkills;
    public static Boss instance;
    public int damage;
    public bool _win;
    public int _life;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        _win = bossSkills.win;
        _life = bossSkills.life;
        _win = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LifeBoss(int damage)
    {
        _life -= damage;
        if (_life < 0)
        {
            Destroy(gameObject);
            _win = true;
        }
    }


    
}
