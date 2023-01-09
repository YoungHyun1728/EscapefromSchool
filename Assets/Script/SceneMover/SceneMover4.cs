using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover4 : MonoBehaviour
{
    void Update()
    {
        if(Player.clear == true)
        {
            SceneManager.LoadScene("ending");
            GameManager.GM.RestartCount.gameObject.SetActive(false);
            GameManager.GM.ClearWithText();


        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage4_F");

            GameManager.GM.BGMAudioSource.Stop();

            GameManager.GM.EffectAudioSource.clip = GameManager.GM.BreakAndCrash;
            GameManager.GM.EffectAudioSource.Play();
        }

    }
}
