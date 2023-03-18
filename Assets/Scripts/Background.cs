using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
