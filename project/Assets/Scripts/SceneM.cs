using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    
    public void Game1()
    {
        SceneManager.LoadScene(5);
    }

    public void Game2()
    {
        SceneManager.LoadScene(1);
    }
}
