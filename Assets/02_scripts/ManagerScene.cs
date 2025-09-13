using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
