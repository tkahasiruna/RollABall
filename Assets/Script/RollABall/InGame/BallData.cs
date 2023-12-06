using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    private int hitPoint;
    public int GetHitPoint
    {
        get { return hitPoint; }
    }
    public int SetHitPoint
    {
        set { hitPoint = value; }
    }
    // BallDataのコンストラクタ
    public BallData(int hitPoint)
    {
        this.hitPoint = hitPoint;
    }
    public class BallController : MonoBehaviour
    {
        private Rigidbody ballRigidBody;
        private void Start()
        {
            ballRigidBody = this.GetComponent<Rigidbody>();
            var ballData = new BallData(5);
            Debug.Log(ballData.GetHitPoint);//5
        }
        public void BallMove(Vector3 direction)
        {
            ballRigidBody.AddForce(direction);
        }
    }

}


