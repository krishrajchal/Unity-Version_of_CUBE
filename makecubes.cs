using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makecubes : MonoBehaviour
{
    public Material mat;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 5;
                cube.AddComponent<Rigidbody>();
                cube.GetComponent<MeshRenderer>().material = mat;
            }
        }
    }
}
