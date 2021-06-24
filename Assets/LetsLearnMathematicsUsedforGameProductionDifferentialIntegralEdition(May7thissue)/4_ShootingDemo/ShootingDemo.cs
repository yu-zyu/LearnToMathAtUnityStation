using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingDemo : MonoBehaviour
{
    Vector3 p1;
    Vector3 target;
    public GameObject _target;
    const float LEN = 10f;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine("loop");
    }

    IEnumerator loop()
    {
        Vector3[] table = new Vector3[]
        {
            new Vector3(1f, 0f, 0f),
            new Vector3(8f, 0f, 0f),
            new Vector3(8f, 8f, 0f),
            new Vector3(0f, 8f, 0f),
            new Vector3(-8f, 2f, 0f),
            new Vector3(6f, -3f, 0f),
        };
        int idx = 0;
        for (; ; )
        {
            target = table[idx];
            if(_target != null)
            {
                _target.transform.position = target;
            }
            yield return new WaitForSeconds(2f);
            idx = (idx + 1) % table.Length;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        p1 += (target - pos) * 4f * Time.deltaTime;
        p1 -= p1 * 1f * Time.deltaTime;
        pos += p1 * Time.deltaTime;
        transform.position = pos;
        transform.rotation = Quaternion.LookRotation(p1, Vector3.forward);
    }
}
