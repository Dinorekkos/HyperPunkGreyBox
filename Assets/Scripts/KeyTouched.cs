using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTouched : MonoBehaviour
{
    public GameObject Overlay;
    public GameObject KeyGeneral;
    public Sprite KeyNormal;
    public Sprite KeyPressed;
    public int ScoreGained;

    bool KeyIsClicked;
    bool FailedNote;

    void Update()
    {
        //Si no le das clic
        if (Overlay.activeSelf == false)
        {
            ScoreGained = 0;
            KeyGeneral.SetActive(false);
            Debug.Log(ScoreGained);
        }

        //Dependiendo del tama�o del Overlay
        if (KeyIsClicked && FailedNote == false)
        {
            if (Overlay.transform.localScale.x > 1.4)
            {
                ScoreGained = 0;
            }
            if (Overlay.transform.localScale.x >= 1.3 && Overlay.transform.localScale.x < 1.4)
            {
                ScoreGained = 100;
            }
            if (Overlay.transform.localScale.x >= 1.2 && Overlay.transform.localScale.x < 1.3)
            {
                ScoreGained = 200;
            }
            if (Overlay.transform.localScale.x >= 0.9 && Overlay.transform.localScale.x < 1.2)
            {
                ScoreGained = 300;
            }
            KeyGeneral.SetActive(false);
            Debug.Log(ScoreGained);
        }
    }

    void OnMouseDown()
    {
        SpriteRenderer spriteRen= gameObject.GetComponent<SpriteRenderer>();
        spriteRen.sprite = KeyPressed;
        KeyIsClicked = true;
    }
}
