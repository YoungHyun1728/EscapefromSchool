using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStart : MonoBehaviour
{
    public void ToStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Stage1");
    }
}
