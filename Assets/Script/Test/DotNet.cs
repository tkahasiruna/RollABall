using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System;
public class DotNet : MonoBehaviour
   


{

  
    private void Start()
    {
        ShowTime();
    }
    void ShowTime()
    {
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é

    }



}