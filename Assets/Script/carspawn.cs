using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carspawn : MonoBehaviour
{
    public Text Timer;
    public float GameTime = 20f;
    public float Delay = 1f;
    public float LastGenerateTime;

    public GameObject[] car1;
    public GameObject[] car2;

    public AudioSource Car1;
    public AudioSource Car2;



    void Start()
    {
        LastGenerateTime = Time.time;
    }

    void Update()
    {
        GameTime -= Time.deltaTime;
        Timer.text = "Time : " + (int)GameTime;

        if (Time.time - LastGenerateTime > Delay)
        {
            GameObject CarInit1 = Instantiate(car1[Random.Range(0, car1.Length)]);
            GameObject CarInit2 = Instantiate(car2[Random.Range(0, car2.Length)]);
            float RandomX1 = Random.Range(0.5f, 7f);
            float RandomX2 = Random.Range(-0.5f, -7f);

            CarInit1.transform.position = new Vector2(RandomX1, -10);
            CarInit2.transform.position = new Vector2(RandomX2, 10);

            Car1.Play();
            Car2.Play();

            LastGenerateTime = Time.time;

        }

        if (GameTime < 0)
        {
            Player.clear = true;
        }
    }

}
