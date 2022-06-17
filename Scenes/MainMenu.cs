using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject  panelOptions,panelCredits;

    private void Awake()
    {
        
        panelOptions.SetActive(false);
        panelCredits.SetActive(false);

    }

    public void MissionSelect()
    {
        SceneManager.LoadScene("MissionSelect");
    }

       public void OptionsOn()
    {
        panelOptions.SetActive(true);
    }

    public void OptionsOff()
    {
        panelOptions.SetActive(false);
    }

    public void CreditsOn()
    {
        panelCredits.SetActive(true);
    }

    public void CreditsOff()
    {
        panelCredits.SetActive(false);
    }

    public void Finish()
    {
        Application.Quit();
    }
   
}
