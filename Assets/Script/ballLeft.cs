using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLeft : MonoBehaviour
{
    public Transform Target;
    public float Speed;

    void Start()
    {
        Speed = Random.Range(8f, 15f);
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }

    }
}
