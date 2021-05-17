using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour
{
    public float delta = 4f;  // Amount to move left and right from the start point
    public float speed = 5f;
    public float direction = 1;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = startPos;
        a.x += direction * (delta * Mathf.Sin(Time.time * speed));
        transform.position = a;
    }
}
