using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static int difficulty = 4;

    public void Back ()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Play()
    {
        if (difficulty == 4)
        {
            SceneManager.LoadScene("Prototype #1");
        }
        else if (difficulty == 5)
        {
            SceneManager.LoadScene("Prototype #2");
        }
        else if (difficulty == 6)
        {
            SceneManager.LoadScene("Prototype #3");
        }
        
    }

    public void SetDifficultyToEasy ()
    {
        difficulty = 4;
        Debug.Log(difficulty);
    }

    public void SetDifficultyToMedium()
    {
        difficulty = 5;
        Debug.Log(difficulty);
    }

    public void SetDifficultyToHard() 
    {
        difficulty = 6;
        Debug.Log(difficulty);
    }

    public void Exit ()
    {
        Application.Quit();
    }
}
