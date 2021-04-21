using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOverlay : MonoBehaviour
{
    public GameObject Key;
    public float Scale;


    void Start()
    {
        gameObject.transform.localScale = new Vector3(Scale, Scale, 1f);
    }

//HOLI CRAYOLIL
//OLI RAVIOLI

//HelloAgain
    void Update()
    {
        float step = 2f;
        gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0f) * step * Time.deltaTime;

        if(gameObject.transform.localScale.x <= 1f)
        {
            gameObject.SetActive(false);
        }
    }
}
