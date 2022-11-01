using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int lifes = 3;
    public TMP_Text textlifes;


    void Update()
    {
        textlifes.text = "Lifes: " + lifes.ToString();

        if(lifes <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
