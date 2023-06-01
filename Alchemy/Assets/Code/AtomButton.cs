using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AtomButton : MonoBehaviour
{
    public ElementsDBase Table;

    public int SN;

    public TMP_Text SerialNumber, Simbol, Property, OxState;
    public void SetStatistics()
    {
        SerialNumber.text = "Serial Number: " + Table.Table[SN].property.SN;
        Simbol.text = "Simbol: " + Table.Table[SN].simbol;
        Property.text = "Property: " + Table.Table[SN].property.name;
        OxState.text = "Oxide State: " + Table.Table[SN].property.OxState;
        Debug.Log(message: Table.Table[SN].property.OxState);
    }
}
