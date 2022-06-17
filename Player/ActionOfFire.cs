using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOfFire : MonoBehaviour
{
    public static ActionOfFire instance;
    public Transform mainGun, especialGun,misselGun;
    public GameObject  basicBullet, especialBullet, especializedBullet = null,misselBullet;
    public GameObject[] powers;
    public GameObject[] especials;
    public CrystalAndUpdate.CrystalType crystalInUSe;
    public int crystalLevel = 0;
    public int specialAmount;
    public int rocketAmount;
   


    private void Awake()
    {
        instance = this;
        crystalInUSe = CrystalAndUpdate.CrystalType.empty;
        
    }


    // Start is called before the first frame update
    void Start()
    {
        specialAmount = 5;
        rocketAmount = 5 ;
       
    }

    // Update is called once per frame
    void Update()
    {
        ActionOfShoot();
        LevelUpShot();


    }

    public void AddRocket()
    {
        rocketAmount++;
    }

    public void AddSpecial()
    {
        specialAmount++;
    }
    public void ActionOfShoot()
    {
        
            //Main GUM
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                if (especializedBullet == null)
                {
                    Instantiate(basicBullet, mainGun.position, mainGun.rotation);
                }

                else if (especializedBullet != null)
                {
                    Instantiate(especializedBullet, mainGun.position, mainGun.rotation);
                }

            }
            //ESPECIAL
            if (Input.GetKeyDown(KeyCode.Space) && specialAmount > 0)
            {
                Instantiate(especialBullet, especialGun.position, especialGun.rotation);
                specialAmount--;
            }
            // Missel
            if (Input.GetKeyDown(KeyCode.LeftShift) && rocketAmount > 0)
            {
                Instantiate(misselBullet, misselGun.position, misselGun.rotation);
                rocketAmount--;
            }
         
       
        
       
        
        
    }
    public void LevelUpShot()
    {
        if(crystalInUSe == CrystalAndUpdate.CrystalType.yellow)
        {
            
            if (crystalLevel == 1)
            {
                especializedBullet = powers[0];
            }

            if (crystalLevel == 2)
            {
                especializedBullet = powers[1];
            }

            if (crystalLevel == 3)
            {
                especializedBullet = powers[2];
            }

            if (crystalLevel == 4)
            {
                especializedBullet = powers[3];
            }
            especialBullet = especials[0];
        }


        if (crystalInUSe == CrystalAndUpdate.CrystalType.red)
        {
            if (crystalLevel == 1)
            {
                especializedBullet = powers[4];
            }

            if (crystalLevel == 2)
            {
                especializedBullet = powers[5];
            }

            if (crystalLevel == 3)
            {
                especializedBullet = powers[6];
            }

            if (crystalLevel == 4)
            {
                especializedBullet = powers[7];
            }
            especialBullet = especials[1];
        }


        if (crystalInUSe == CrystalAndUpdate.CrystalType.purple)
        {
            if (crystalLevel == 1)
            {
                especializedBullet = powers[8];
            }

            if (crystalLevel == 2)
            {
                especializedBullet = powers[9];
            }

            if (crystalLevel == 3)
            {
                especializedBullet = powers[10];
            }

            if (crystalLevel == 4)
            {
                especializedBullet = powers[11];
            }
            especialBullet = especials[2];
        }


        if (crystalInUSe == CrystalAndUpdate.CrystalType.blue)
        {
            if (crystalLevel == 1)
            {
                especializedBullet = powers[12];
            }

            if (crystalLevel == 2)
            {
                especializedBullet = powers[13];
            }

            if (crystalLevel == 3)
            {
                especializedBullet = powers[14];
            }

            if (crystalLevel == 4)
            {
                especializedBullet = powers[15];
            }
            especialBullet = especials[3];
        }
    }
   

    public void OnTriggerEnter2D(Collider2D other)
    {
       

        if (crystalInUSe == other.GetComponent<CrystalAndUpdate>().type && crystalLevel <4)
        {
            crystalLevel++;
            Destroy(other.gameObject);

            
        }
        
        else
        {
            crystalInUSe = other.GetComponent<CrystalAndUpdate>().type;

            if (other.gameObject.GetComponent<CrystalAndUpdate>().type == CrystalAndUpdate.CrystalType.yellow)
            {
                especializedBullet = powers[0];
                //especialBullet = especials[0];
                crystalLevel = 1;
            }

            if (other.gameObject.GetComponent<CrystalAndUpdate>().type == CrystalAndUpdate.CrystalType.blue)
            {
                especializedBullet = powers[12];
                crystalLevel = 1;
            }

            if (other.gameObject.GetComponent<CrystalAndUpdate>().type == CrystalAndUpdate.CrystalType.red)
            {
                especializedBullet = powers[4];
                crystalLevel = 1;
            }

            if(other.gameObject.GetComponent<CrystalAndUpdate>().type == CrystalAndUpdate.CrystalType.purple)
            {
                especializedBullet = powers[8];
                crystalLevel = 1;
            }
        }
        
        Destroy(other.gameObject);
        
    }


    

}
