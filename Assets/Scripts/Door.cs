using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.UIElements;

public class Door : MonoBehaviour
{
    [SerializeField] AudioSource doorm;
    [SerializeField] AudioClip DoorSound;
    public Vector3 OpenPosition;
    public Vector3 ClosePosition;
    public bool isOpen = true;
    public bool action = false;
    public void ButtonPressed()
    {
        isOpen = !isOpen;
        action = true;
        doorm.PlayOneShot(DoorSound);
    }

    private void Update()
    {
        Vector3 NextPosition;
        if (isOpen)
        {
            NextPosition = OpenPosition;
        }
        else
        {
            NextPosition = ClosePosition;
        }
        if (action) 
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, NextPosition, 12f * Time.deltaTime);
            
            if (Vector3.Distance(transform.localPosition, NextPosition) < 0.01f) 
            {
                transform.localPosition = NextPosition;
                action = false;
            }
        }
        
    }
}
