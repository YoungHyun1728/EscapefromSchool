using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDrop : MonoBehaviour
{
    public float BookDropTime = 1f;
    public float LastDropTime;
    public float CurrentTime;
    public float ScaleMulti = 0.1f;

    public GameObject RedJone;
    public GameObject Book;


    // Start is called before the first frame update
    void Start()
    {
        LastDropTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //CurrentTime = Time.time;
        float BookRatio = (Time.time - LastDropTime) / BookDropTime;
        ScaleMulti = BookRatio;

        RedJone.transform.localScale = new Vector3(ScaleMulti, ScaleMulti, ScaleMulti);

        if(ScaleMulti >= 1)
        {
            GameObject BookSpawn = Instantiate(Book);
            BookSpawn.transform.position = transform.position;
            GameManager.GM.EffectAudioSource.clip = GameManager.GM.BookDropSound;
            GameManager.GM.EffectAudioSource.Play();
            Destroy(this.gameObject);
        }
    }
}
