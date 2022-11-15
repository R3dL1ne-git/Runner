using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject recordsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void RecordsPanel()
    {
        recordsPanel.SetActive(true);
    }

    public void ExitRecordsPanel()
    {
        recordsPanel.SetActive(false);
    }
}
