using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadArea : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {

            Debug.Log("Dead");

        }


    }

}