using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float movespeed = 5f;
    void Start()
    {

    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        Vector3 direct = new Vector3(h, v, 0);

        Debug.Log("h: " + h + " , v : " + v);

        transform.position = transform.position + direct * movespeed * Time.deltaTime;


        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector3 direction = new Vector3(horizontal, 0f, vertical);
        //transform.Translate(direction * movespeed * Time.deltaTime);
    }
}
