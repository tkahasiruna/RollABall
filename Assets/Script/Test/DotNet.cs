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
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������

    }



}