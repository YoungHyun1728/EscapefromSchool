using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover1 : MonoBehaviour
{
    void Update()
    {
        if(Player.clear == true)
        {
            SceneManager.LoadScene("stage2");

            GameManager.GM.BGMAudioSource.clip = GameManager.GM.BGM1;
            GameManager.GM.BGMAudioSource.Play();
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage1_F");

            GameManager.GM.BGMAudioSource.Stop();

            GameManager.GM.EffectAudioSource.clip = GameManager.GM.BreakGlass;
            GameManager.GM.EffectAudioSource.Play();
        }

    }
}
