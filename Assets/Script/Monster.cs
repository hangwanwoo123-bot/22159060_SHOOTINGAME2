using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    public float spd = 1.0f;

    GameObject target;

    Vector3 direct = Vector3.down;
    public GameObject preEX;

    void Start()
    {
        target = GameObject.Find("Character");

        int rndNum = Random.Range(0, 10);
        if(rndNum % 3  == 0)
        {
            direct = target.transform.position - transform.position;
            direct.Normalize();
        }
    }

    // Update is called once per frame
   private void Update()
    {
        transform.position = transform.position + direct * spd * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ex = Instantiate(preEX);
        ex.transform.position = transform.position;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

