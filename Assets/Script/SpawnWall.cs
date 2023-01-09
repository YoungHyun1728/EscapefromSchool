using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject[] Enter1;
    public GameObject[] Enter2;
    public GameObject[] Enter3;



    // Start is called before the first frame update
    void Start()
    {
        Enter1[Random.Range(0, Enter1.Length)].gameObject.SetActive(true);
        Enter2[Random.Range(0, Enter2.Length)].gameObject.SetActive(true);
        Enter3[Random.Range(0, Enter3.Length)].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
