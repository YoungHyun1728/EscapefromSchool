using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawn : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;

    void Update()
    {
        
    }

    public void pitch()
    {
        Instantiate(ball);
    }
}
