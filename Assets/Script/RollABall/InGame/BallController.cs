using UnityEngine;
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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}