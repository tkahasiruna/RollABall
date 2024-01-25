using UnityEngine;

public class AbsoluteMovement : MonoBehaviour
{
	// UI�̌��݂̑���
	public float speed = 1;

	// �Q�[���I�u�W�F�N�g����擾�������݂̌���
	public Vector3 currentDirection;


	// v.x = cd.x�Av.y = cd.y�ɕ�����ݒ�
	public void MoveDirectionXZ(Vector2 moveValue)
	{
		// �ʒu�𒆐S�Ƀ��Z�b�g����
		currentDirection = new Vector3(moveValue.x, 0, moveValue.y);
	}

	// v.x = cd.x�Av.y = cd.z�ɕ�����ݒ�
	public void MoveDirectionXY(Vector2 moveValue)
	{
		// �ʒu�𒆐S�Ƀ��Z�b�g����
		currentDirection = moveValue;
	}

	public void Update()
	{
		// �g�����X�t�H�[�������݂̌����̕��֐ݒ肳�ꂽ�X�s�[�h�ňړ�
		transform.position += currentDirection * speed * Time.deltaTime;
	}
}

