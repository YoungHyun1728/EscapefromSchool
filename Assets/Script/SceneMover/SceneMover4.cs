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
        }

        if (Player.isdead == true)
        {
            SceneManager.LoadScene("stage4_F");
        }

    }
}
