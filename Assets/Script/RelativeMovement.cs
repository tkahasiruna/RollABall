using UnityEngine;

public class RelativeMovement : MonoBehaviour
{
    // �e�l�ɑΉ����鑬�x�AnaturalSpeed�͓��͂̉e�����󂯂Ȃ�
    public float strafeSpeed, forwardSpeed, naturalSpeed;

    // ���݂̈ړ�����
    private Vector2 inputDirection;

    // ���͂̌�����ݒ�
    public void SetDirectionInput(Vector2 moveValue)
    {
        inputDirection = moveValue;
    }

    // ���͂Ƒ��x�Ɋ�Â��������v�Z
    public Vector3 CalculateDirection()
    {
        return (transform.forward * inputDirection.y * forwardSpeed +
transform.right * inputDirection.x * strafeSpeed);
    }

    public void Update()
    {
        // ���݂̉�]�l����g�����X�t�H�[������]
        Vector3 direction = CalculateDirection() + transform.forward * naturalSpeed;
        // �v���C���[�Ɉړ���������(�v���C���[�𓮂���)
        transform.position += direction * Time.deltaTime;
    }
}

