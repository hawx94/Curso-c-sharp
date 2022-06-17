using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasHUD : MonoBehaviour
{
    public Text specialAmount,lifesAmount,rocketAmount;
    public Text specialAmount2, lifesAmount2, rocketAmount2;
    public GameObject pauserPanel;

    // Start is called before the first frame update
    void Start()
    {
        HudIntel();
        pauserPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HudIntel();
        Pauser();
    }

    public void HudIntel()
    {
        specialAmount.text = ActionOfFire.instance.specialAmount.ToString();
        rocketAmount.text = ActionOfFire.instance.rocketAmount.ToString();
        lifesAmount.text = PlayerHealth.instance.lifes.ToString();
        
        if (GameManager.instance.isToPlayer)
        {
            specialAmount2.text = FirePlayer2.instance.specialAmount2.ToString();
            rocketAmount2.text = FirePlayer2.instance.rocketAmount2.ToString();
            lifesAmount2.text = Player2Health.instance.lifes.ToString();
        }
        
    }

    public void Pauser()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauserPanel.SetActive(true);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauserPanel.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MissionSelect");
    }
}
