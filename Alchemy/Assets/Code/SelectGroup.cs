using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectGroup : MonoBehaviour
{
    public GameObject []  Groups = new GameObject[16];

    public void GetGroup(int ID)
    {
        for(int i = 0; i < Groups.Length; i++)
        {
            Groups[i].GetComponent<Image>().color.Equals(new Vector4(255f,255f,255f,0f));
        }
        Groups[ID].GetComponent<Image>().color.Equals(new Vector4(255f, 0f, 0f, 195f));
    }
}
