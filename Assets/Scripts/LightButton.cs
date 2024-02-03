using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    [SerializeField] AudioSource Light;
    [SerializeField] AudioClip LightSound;
    public GameObject doorLight;
    Vector3 position;
    void Awake()
    {
        position = transform.localPosition;
    }

    void OnMouseDown()
    {
        Light.pitch = 1f;
        Light.PlayOneShot(LightSound);
        transform.localPosition = position - transform.up * -0.03f;
        doorLight.SetActive(true);
    }

    void OnMouseUp()
    {
        Light.pitch = 0f;
        transform.localPosition = position;
        doorLight.SetActive(false);
    }
}
