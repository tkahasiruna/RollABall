using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetaType : MonoBehaviour
{

    int integerNumber;
    float floatNumber;
    // double: 小数(小数点以下第15位まで)
    double doubleNumber;
    char character;
    string stringDate;
    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 8;
        floatNumber = 1.5f;
        Debug.Log(floatNumber);
        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);
        character = 'u';
        Debug.Log(character);
        



    }


}
