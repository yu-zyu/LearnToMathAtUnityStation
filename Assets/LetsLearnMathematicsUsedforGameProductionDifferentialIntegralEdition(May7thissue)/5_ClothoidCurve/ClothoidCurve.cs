using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothoidCurve : MonoBehaviour
{
    float t;
    float t1;
    // Update is called once per frame
    void Update()
    {
        // x(l) = ∫cosθ^2 / 2 * dθ
        // y(l) = ∫sinθ^2 / 2 * dθ

        //var pos = transform.position;
        //pos.x += Mathf.Cos(Time.time * Time.time * 0.5f);
        //pos.y += Mathf.Sin(Time.time * Time.time * 0.5f);
        //transform.position = pos;

        // ∫θ^2 / 2  = ∫xdx
        t1 += Time.deltaTime;
        t += t1 * Time.deltaTime;
        var pos = transform.position;
        pos.x += Mathf.Cos(t);
        pos.y += Mathf.Sin(t);
        transform.position = pos;
    }
}
