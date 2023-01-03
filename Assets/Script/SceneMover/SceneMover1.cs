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
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage1_F");
        }

    }
}
