using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscr : MonoBehaviour
{
    public Material mBg;

    public float spd = 0.2f;

    private void Update()
    {
        Vector2 direction = Vector2.up;
        mBg.mainTextureOffset += direction * spd * Time.deltaTime;
    }
}
