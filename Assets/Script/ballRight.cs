using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRight : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
        if(transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
