using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RacketText : MonoBehaviour
{
    TextMeshPro Power;
    // Start is called before the first frame update
    private void Awake()
    {
        Power = GetComponent<TextMeshPro>();
    }

    public void SetRacketText(string text)
    {
        Power.text = text;
    }
}
