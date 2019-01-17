using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void CheckSpawners()
    {
        if (SceneManager.GetActiveScene().name != "Menu" && SceneManager.GetActiveScene().name != "Game Over")
        {
            if (GameObject.Find("Spawner") == null)
            {
                SceneManager.LoadScene(nextScene());
            }
        }
    }
    public string nextScene()
    {
        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            return "LevelOne";
        }
        else if (SceneManager.GetActiveScene().name == "LevelOne")
        {
            return "LevelTwo";
        }
        else if (SceneManager.GetActiveScene().name == "LevelTwo")
        {
            return "Game Over";
        }
        else
        {
            return "menu";
        }
    }
}
