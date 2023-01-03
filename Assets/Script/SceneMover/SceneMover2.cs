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
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage2_F");
        }

    }
}
