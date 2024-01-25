using UnityEngine;

public class UIMovement : MonoBehaviour
{
	// UI�̌��݂̑���
	public float speed = 100;

	// �Q�[���I�u�W�F�N�g����擾�������݂̌���
	public Vector3 currentDirection;


	// �w����ʏ�Ńh���b�O����邽�тɌĂяo�����֐�
	public void MoveDirection(Vector2 moveValue)
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

