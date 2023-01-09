using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBookDrop : MonoBehaviour
{
    public float BookDropSpawnDealy = 3f;
    public float LastGenerateTime;
    public float[] BookDropY;
    public float X;

    public GameObject BookDrops;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        LastGenerateTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - LastGenerateTime > BookDropSpawnDealy)
        {
            GameObject BookDropInit = Instantiate(BookDrops);
            //float RandomY = BookDropY[Random.Range(0, BookDropY.Length)];
            float RandomY = Player.transform.position.y;
            float RandomX = Player.transform.position.x + Random.Range(-X, X);
            //float RandomX = Random.Range(-7, 7);

            BookDropInit.transform.position = new Vector2(RandomX, RandomY);
            LastGenerateTime = Time.time;

        }

  
    }
}
