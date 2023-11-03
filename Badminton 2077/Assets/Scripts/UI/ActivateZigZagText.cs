using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivateZigZagText : MonoBehaviour
{
    bool ZigZagSelectText;

    public TextMeshProUGUI ShowText;

    void Start()
    {
        ShowText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ZigZagSelectText = GameObject.Find("Scripts").GetComponent<SelectRacket>();

        if (ZigZagSelectText == true)
        {
            ShowText.enabled = true;
        }

        if (ZigZagSelectText == false)
        {
            ShowText.enabled = false;
        }
    }
}
