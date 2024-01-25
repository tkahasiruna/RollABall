using UnityEngine;

public class Rotation : MonoBehaviour
{
    // ��]���x�̊��x�A60���ǂ��ł��傤
    public float pitchAngularSpeed, rollAngularSpeed, yawAngularSpeed;

    // ���ݎZ�o����Ă���1�b������̉�]���x
    private float deltaX, deltaY, deltaZ;

    // v.x = cd.x�Av.y = cd.y�ɕ�����ݒ�
    public void DeltaAngles(Vector2 moveValue)
    {
        deltaX = moveValue.x;
        deltaY = moveValue.y;
    }


    public void Update()
    {
        // ���݂̉�]�l����g�����X�t�H�[������]
        transform.Rotate(
    deltaY * pitchAngularSpeed * Time.deltaTime,
    deltaZ * yawAngularSpeed * Time.deltaTime,
    -deltaX * rollAngularSpeed * Time.deltaTime, Space.Self);
    }
}

