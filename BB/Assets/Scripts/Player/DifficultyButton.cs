using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static DifficultyManager;

public class DifficultyButton : MonoBehaviour
{
   public void SetEasy()
    {
        DifficultyManager.Easy();
        SceneManager.LoadScene(8);
    }
    public void SetModerate()
    {
        DifficultyManager.Moderate();
        SceneManager.LoadScene(8);
    }
    public void SetHard()
    {
        DifficultyManager.Hard();
        SceneManager.LoadScene(8);
    }
}
