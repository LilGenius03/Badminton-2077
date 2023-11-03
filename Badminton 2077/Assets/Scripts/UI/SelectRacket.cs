using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class SelectRacket : MonoBehaviour
{
    public string[] rNames = { "Power", "Rocket", "Zigzag" };
    public Sprite[] racket = new Sprite[3];
    public GameObject shown;
    public TMP_Text rName;
    public TMP_Text rNameShadow;
    bool p1Ready;
    bool p2Ready;

    public int Options;

    void Start()
    {
        p1Ready = false;
        p2Ready = false;
        RacketPicker.p1Select = 0;
        RacketPicker.p2Select = 0;

        Options = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Options++;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Options--;
        }

        if (Options < 0)
        {
            Options = 0;
        }

        if (Options > 2)
        {
            Options = 2;
        }
        shown.GetComponent<Image>().sprite = racket[Options];
        rName.text = rNames[Options];
        rNameShadow.text = rNames[Options];
        if (Input.GetKeyDown(KeyCode.W))
        {
            p1Ready = true;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            p2Ready = true;
        }


        if (p1Ready == true & p2Ready == true)
        {
            RacketPicker.p1Select = Options;
            RacketPicker.p2Select = Options;
            SceneManager.LoadScene("Main");
        }
    }
}
