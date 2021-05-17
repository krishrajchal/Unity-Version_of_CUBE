using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/cam")]

public class cam : MonoBehaviour
{
    float mouseX, mouseY;
    public Transform playerBody;
    float xRotation = 0f;

    void Update()
    {
        if (!GameObject.Find("actualPlayer").GetComponent<player>().ded)
        {
            float mouseX = Input.GetAxis("Mouse X") * 400 * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * 400 * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
