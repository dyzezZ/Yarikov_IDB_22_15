using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class project : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void start_cylinder()
    {
        cylinder.SetActive(!cylinder.activeSelf);
    }
    public void start_cube()
    {
     cube.SetActive(!cube.activeSelf);
    }
}
