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
        DateTime now = DateTime.Now; // 今の時間を取得する
        Debug.Log(now); // 今の時間をゲームに表示する

    }



}