using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour
{
    public GameObject Cube;
    public void Button_click()
    {
        if (Cube.activeInHierarchy == true)
            Cube.SetActive(false);
        else
            Cube.SetActive(true);
    }
}