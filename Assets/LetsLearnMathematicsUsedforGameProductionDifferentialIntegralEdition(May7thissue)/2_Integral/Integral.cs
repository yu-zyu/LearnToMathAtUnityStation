using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integral : MonoBehaviour
{
    float func(float x)
    {
        return 4f / (1f + x * x);
    }

    // Update is called once per frame
    void Update()
    {
        float r = 0f;
        const float dx = 0.1f;
        for(var x = 0f; x < 1f; x += dx)
        {
            r += func(x) * dx;
        }
        Debug.Log(r);
    }
}
