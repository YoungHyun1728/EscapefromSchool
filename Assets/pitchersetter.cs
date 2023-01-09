using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class pitchersetter : MonoBehaviour
{
    public GameObject[] pitcher;
    void Start()
    {
        for (int i = 0; i < 8; i += 2)
        {
            float Rand = Random.Range(0f, 10f);
            
            if(Rand > 5f)
                pitcher[i].SetActive(true);
            else
                pitcher[i+1].SetActive(true);

        }
    }

    void Update()
    {
        
    }
}
