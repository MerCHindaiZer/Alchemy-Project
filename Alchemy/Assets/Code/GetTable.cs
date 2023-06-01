using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTable : MonoBehaviour
{
    public GameObject Table;
    public void SpawnTable()
    {
        if (Table.active == false)
            Table.SetActive(true);
        else
            Table.SetActive(false);
    }
}
