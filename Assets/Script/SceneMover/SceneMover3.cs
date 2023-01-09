using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover3 : MonoBehaviour
{
    void Update()
    {
        if(Player.clear == true)
        {
            SceneManager.LoadScene("stage4");

            GameManager.GM.BGMAudioSource.clip = GameManager.GM.BGM3;
            GameManager.GM.BGMAudioSource.Play();
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage3_F");

            GameManager.GM.BGMAudioSource.Stop();

            GameManager.GM.EffectAudioSource.clip = GameManager.GM.GameOverSound[Random.Range(0, 2)];
            GameManager.GM.EffectAudioSource.Play();
        }

    }
}
