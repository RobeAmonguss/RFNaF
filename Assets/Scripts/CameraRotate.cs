using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float sensitivy = 150f;
    float rotateZone = Screen.width / 5;

    //float xRot = 90f;
    //public float sensitive = 300f;

    void MouseMove()
    {
        //xRot += Input.GetAxis("Mouse X") * sensitive * Time.deltaTime;
        //xRot = Mathf.Clamp(xRot, 45f, 135f);
        //transform.rotation = Quaternion.Euler(0f, xRot, 0);
    }

    void Update()
    {
        //MouseMove();

        if (Input.mousePosition.x < rotateZone && transform.rotation.eulerAngles.y > 45)
        {
            transform.Rotate(0, -sensitivy * Time.deltaTime, 0);
        }
        if (Input.mousePosition.x > Screen.width - rotateZone && transform.rotation.eulerAngles.y < 135)
        {
            transform.Rotate(0, sensitivy * Time.deltaTime, 0);
        }
    }
}
