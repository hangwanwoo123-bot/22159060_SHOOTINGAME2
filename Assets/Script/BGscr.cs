using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscr : MonoBehaviour
{
    public Material mBg;

    public float spd = 0.2f;


    private void Start()
    {
        // 1. 오브젝트의 Renderer에서 Material을 가져와서 인스턴스화합니다.
        mBg = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        Vector2 direction = Vector2.up;
        mBg.mainTextureOffset += direction * spd * Time.deltaTime;
    }
}
