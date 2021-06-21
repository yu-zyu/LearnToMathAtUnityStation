using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako3 : MonoBehaviour
{
    Vector3 p1;
    const float LEN = 10f;

    private void Start()
    {
        p1.x = LEN;
    }
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        p1.x += -pos.x  * Time.deltaTime;
        pos.x += p1.x * Time.deltaTime;
        transform.position = pos;
    }
}

