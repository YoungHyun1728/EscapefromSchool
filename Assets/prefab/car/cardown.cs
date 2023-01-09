using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardown : MonoBehaviour
{
    public float Speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * Speed);

    }
}
