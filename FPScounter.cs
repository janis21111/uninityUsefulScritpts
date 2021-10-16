using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPScounter : MonoBehaviour
{

    public float timer, refresh, avgFramerate;
    public string display = "{0} FPS";
    [SerializeField] private TMP_Text text;


    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }


    // Update is called once per frame
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;


        if (timer <= 0)
        {
            avgFramerate = (int) (1f / timelapse);
        }

        text.text = string.Format(display, avgFramerate.ToString());

    }
    
    
    
    
    
}
