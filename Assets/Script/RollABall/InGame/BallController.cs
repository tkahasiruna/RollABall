using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{


    private Rigidbody ballRigidBody;

    private void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();

        var ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint);


    }



    public void BallMove(Vector3 directuon)

    {



        ballRigidBody.AddForce(directuon);

    }

}


   
