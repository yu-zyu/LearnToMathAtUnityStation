using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako4 : MonoBehaviour
{
    Vector3 p1;
    const float LEN = 10f;
    //const float LEN2 = 10f;

    private void Start()
    {
        p1.x = LEN;
        //p1.y = LEN2;
    }
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        p1.x += -pos.x * Time.deltaTime;
        pos.x += p1.x * Time.deltaTime;

        p1.y += -pos.y * Time.deltaTime;
        pos.y += p1.y * Time.deltaTime;
        transform.position = pos;
    }
}

