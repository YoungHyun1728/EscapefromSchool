using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawn : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void pitch()
    {
        GameObject ballInit = Instantiate(ball);
        ballInit.transform.position = transform.position;
        GameManager.GM.EffectAudioSource.clip = GameManager.GM.BallThrowSound;
        GameManager.GM.EffectAudioSource.Play();
    }
}
