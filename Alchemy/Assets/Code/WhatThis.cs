using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhatThis : MonoBehaviour
{
    public ElementsDBase Base;
    public TMP_Text SN;
    
    public void Check()
    {
       Debug.Log(message: int.Parse(SN.text)); 
    }
}
