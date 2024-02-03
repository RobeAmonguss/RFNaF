using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] AudioSource win;
    [SerializeField] AudioClip winsound, winsoundkids;
    private int time = 0;
    private Text clock;
    private void Awake()
    {
        clock = gameObject.GetComponent<Text>();
        InvokeRepeating("Timer", 2f, 2f);
    }

    public void Timer()
    {
        time++;
        clock.text = time.ToString() + " AM";
        if (time >= 6)
        {
            win.PlayOneShot(winsound);
            Invoke("Timer", 2f);
            win.PlayOneShot(winsoundkids);
            CancelInvoke();
            Invoke("timer", 15f);
            Application.Quit();
        }
    }
}
