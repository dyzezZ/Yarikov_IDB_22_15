using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cylinder : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cube;
    public GameObject cam;
    public GameObject bcam;
    public Text counterText;
    public int counter = 5;
    public float Speed = 5f;
    

    // Выполняется единожны при запуске сцены
    void Start()
    {
        
    }

    // Работает каждый раз, когда проигрывается кадр
    void FixedUpdate()
    {
        counterText.text = counter.ToString();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }


        if (counter <= 0) 
        {
            cylinder.SetActive(false);
            counterText.text = "Игра окончена";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == cube)
        {
            Debug.Log("CEN");
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            counter--;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionStay(Collision collision)
    {

    }
}
