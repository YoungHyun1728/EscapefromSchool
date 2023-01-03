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
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage3_F");
        }

    }
}
