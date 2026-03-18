using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletObj;
    public GameObject bulletFireObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isFire = Input.GetButton("Jump");
        if (isFire)
        {
            GameObject bullet = Instantiate(bulletObj);
            bullet.transform.position = bulletFireObj.transform.position;
        }
    }
}
