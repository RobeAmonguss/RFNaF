using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    Vector3 position;
    public Door door;

    void Awake()
    {
        position = transform.localPosition;
    }

    private void OnMouseDown()
    {
        transform.localPosition = position - transform.up * -0.03f;
        door.ButtonPressed();
        Invoke("MouseUp", 0.1f);
    }

    void MouseUp()
    {
        transform.localPosition = position;
    }
}
