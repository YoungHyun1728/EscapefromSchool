using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover2 : MonoBehaviour
{
    void Update()
    {
        if(Player.clear == true)
        {
            SceneManager.LoadScene("stage3");

            GameManager.GM.BGMAudioSource.clip = GameManager.GM.BGM2;
            GameManager.GM.BGMAudioSource.Play();
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage2_F");

            GameManager.GM.BGMAudioSource.Stop();

            GameManager.GM.EffectAudioSource.clip = GameManager.GM.GameOverSound[Random.Range(0, 2)];
            GameManager.GM.EffectAudioSource.Play();
        }

    }
}
