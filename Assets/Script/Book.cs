using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBook", 0.75f);
    }


    public void DestroyBook()
    {
        Destroy(this.gameObject);
    }
}
