using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Speed = Random.Range(0.8f * Speed, 1.2f * Speed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Pos = transform.position;

        Pos.x += Speed * Time.deltaTime;

        transform.position = Pos;
    }
}
