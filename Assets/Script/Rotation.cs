using UnityEngine;

public class Rotation : MonoBehaviour
{
    // 回転速度の感度、60が良いでしょう
    public float pitchAngularSpeed, rollAngularSpeed, yawAngularSpeed;

    // 現在算出されている1秒当たりの回転速度
    private float deltaX, deltaY, deltaZ;

    // v.x = cd.x、v.y = cd.yに方向を設定
    public void DeltaAngles(Vector2 moveValue)
    {
        deltaX = moveValue.x;
        deltaY = moveValue.y;
    }


    public void Update()
    {
        // 現在の回転値からトランスフォームを回転
        transform.Rotate(
    deltaY * pitchAngularSpeed * Time.deltaTime,
    deltaZ * yawAngularSpeed * Time.deltaTime,
    -deltaX * rollAngularSpeed * Time.deltaTime, Space.Self);
    }
}

