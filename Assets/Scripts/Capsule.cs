using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float baseSpeed = 3f;

    public float newSize = 1f;

    void Update()
    {
        
    }

    public void Spin()
    {
        float animation = baseSpeed + Mathf.Sin(Time.time * 8f) * baseSpeed / 7f;
        transform.Rotate(baseSpeed, animation, 0);
    }

    public void sizeChange()
    {
        newSize = Random.Range(.5f, 10.0f);
        transform.localScale = Vector3.one * newSize;
    }

}
