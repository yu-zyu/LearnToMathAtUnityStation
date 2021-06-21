using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako1 : MonoBehaviour
{
    const float LEN = 10f;
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x += Mathf.Cos(Time.time) * LEN * Time.deltaTime;
        transform.position = pos;
    }
}
