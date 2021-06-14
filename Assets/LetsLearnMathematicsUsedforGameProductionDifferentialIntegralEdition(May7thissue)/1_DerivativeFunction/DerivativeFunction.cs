using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerivativeFunction : MonoBehaviour
{
    public float h;

    public float func(float x)
    {
        return x * x;
    }
    public float derivative(float x)
    {
        return (func(x + h) - func(x)) / h;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = func(3f);
        Debug.Log(y);
        float y1 = derivative(3f);
        Debug.Log(y1);
    }
}
