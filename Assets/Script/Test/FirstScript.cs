using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int number;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        number = 151;
        Debug.Log(number);
        number = 251;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
