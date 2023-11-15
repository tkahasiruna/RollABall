private Rigidbody ballRigidBody;
private void Start()
{
    ballRigidBody = Ball.GetComponent<Rigidbody>();
}
void Update()
{
    if (Keyboard.current.wKey.isPressed)
    {
        ballRigidBody.AddForce(Vector3.forward);
    }
    if (Keyboard.current.aKey.isPressed)
    {
        ballRigidBody.AddForce(Vector3.left);
    }
    if (Keyboard.current.sKey.isPressed)
    {
        ballRigidBody.AddForce(Vector3.back);
    }
    if (Keyboard.current.dKey.isPressed)
    {
        ballRigidBody.AddForce(Vector3.right);
    }
}