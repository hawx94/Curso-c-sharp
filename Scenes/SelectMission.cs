using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMission : MonoBehaviour
{
    public Button lv2,lv3,lv4,lv5;
    public static SelectMission instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        UnlockLv2();
    }

    public void Lv1()
    {
        SceneManager.LoadScene("Lv 1");
    }

    public void Lv2()
    {
        SceneManager.LoadScene("Lv 2");
    }
    public void Lv3()
    {
        SceneManager.LoadScene("Lv 3");
    }
    public void Lv4()
    {
        SceneManager.LoadScene("Lv 4");
    }
    public void Lv5()
    {
        SceneManager.LoadScene("Lv 5");
    }
   
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void UnlockLv2()
    {
        if (PlayerPrefs.GetInt("lv2R") == 1 )
        {
            lv2.interactable = true;
        }
        else
        {
            lv2.interactable = false;
        }
    }

    public void UnlockLv3()
    {
        if (PlayerPrefs.GetInt("lv3R") == 2)
        {
            lv3.interactable = true;
        }
        else
        {
            lv3.interactable = false;
        }
    }

    public void UnlockLv4()
    {
        if (PlayerPrefs.GetInt("lv4R") == 3)
        {
            lv4.interactable = true;
        }
        else
        {
            lv4.interactable = false;
        }
    }

    public void UnlockLv5()
    {
        if (PlayerPrefs.GetInt("lv5R") == 4)
        {
            lv5.interactable = true;
        }
        else
        {
            lv5.interactable = false;
        }
    }
}
