using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivateRocketText : MonoBehaviour
{
    bool RocketSelectText;

    public TextMeshProUGUI ShowText;

    void Start()
    {
        ShowText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /*RocketSelectText = GameObject.Find("Scripts").GetComponent<SelectRacket>().RocketSelect;

        if (RocketSelectText == true)
        {
            ShowText.enabled = true;
        }

        if (RocketSelectText == false)
        {
            ShowText.enabled = false;
        }*/
    }
}
