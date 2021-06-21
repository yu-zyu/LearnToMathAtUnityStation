using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako : MonoBehaviour
{
    const float LEN = 10f;
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = Mathf.Sin(Time.time) * LEN;
        transform.position = pos;
        
    }
}
