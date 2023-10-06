using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperMeter : MonoBehaviour
{
    public Slider superMeter;
    
   public void SetMaxMeter(int meter)
    {
       superMeter.maxValue = meter;
        superMeter.value = meter;
    }

    public void SetMeter(int meter)
    {
        superMeter.value = meter;
    }

 

}
