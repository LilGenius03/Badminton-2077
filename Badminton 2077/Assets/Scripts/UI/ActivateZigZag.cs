using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateZigZag : MonoBehaviour
{
    public Image rend;

    bool ZigZagSelect;

    private void Start()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ZigZagSelect = GameObject.Find("Scripts").GetComponent<SelectRacket>().ZigZagSelect;

        if (ZigZagSelect == true)
        {
            rend.enabled = true;
        }

        if (ZigZagSelect == false)
        {
            rend.enabled = false;
        }
    }
}
