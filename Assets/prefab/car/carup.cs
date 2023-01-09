using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carup : MonoBehaviour
{
    public float Speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);

    }
}
