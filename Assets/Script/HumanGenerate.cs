using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanGenerate : MonoBehaviour
{
    public Text Timer;
    public float GameTime = 30f;
    public float HumanGenerateDelay = 1f;
    public float LastGenerateTime;

    public GameObject[] Human;

    // Start is called before the first frame update
    void Start()
    {
        LastGenerateTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        GameTime -= Time.deltaTime;
        Timer.text = "Time : " + (int)GameTime;

        if (Time.time - LastGenerateTime > HumanGenerateDelay)
        {
            GameObject HumanInit = Instantiate(Human[Random.Range(0, Human.Length)]);
            float RandomY = Random.Range(-2.5f, 2.5f);

            HumanInit.transform.position = new Vector2(-7.5f, RandomY);
            LastGenerateTime = Time.time;

        }

        if(GameTime < 0)
        {
            Player.isdead = true;
        }
    }
}
