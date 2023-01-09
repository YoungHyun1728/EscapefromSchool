using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStart : MonoBehaviour
{

    private void Awake()
    {
        Screen.SetResolution(1440, 900, true);
    }
    public void ToStartScene()
    {
        GameManager.GM.PlayeyDie();
        GameManager.GM.RestartCount.gameObject.SetActive(false);
        SceneManager.LoadScene("Start");
        if(GameManager.GM.IsClear == true)
        {
            GameManager.GM.IsClear = false;
            GameManager.GM.GameRestartCount = 1;
            GameManager.GM.SetRestartText();
        }

    }

    public void GameStart()
    {
        GameManager.GM.RestartCount.gameObject.SetActive(true);

        SceneManager.LoadScene("Stage1");

        GameManager.GM.BGMAudioSource.clip = GameManager.GM.BGM1;
        GameManager.GM.BGMAudioSource.Play();
    }
}
