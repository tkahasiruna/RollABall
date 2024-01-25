
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class JoystickController : MonoBehaviour, IDragHandler,
    IEndDragHandler

{


	public float maxDistance;

	// �N���b�N�����o�I�ɕ\������
	public Transform joystickHandle;

	// Vector2�������Ɏ��UnityEvent���쐬
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2> { }

	// �W���C�X�e�B�b�N�̒l��XY��-1�`1�V�X�e���ň����Ɏ��C�x���g
	public Vector2UnityEvent JoystickOutput;

	// �n���h���̃��[�J���ʒu�̌��ς�����v�Z
	public Vector3 GetPosition(Vector3 userInput)
	{
		Vector3 dir = userInput - transform.position;

		if (Vector3.SqrMagnitude(dir) > maxDistance * maxDistance)
		{
			dir = dir.normalized * maxDistance;
		}

		return dir;
	}


	public void OnDrag(PointerEventData eventData)

    {
		// �����Ń��[�J���ʒu��T�d�ɐݒ肷��
		joystickHandle.localPosition = GetPosition(eventData.position);

		// ���͂̊�����0�`1�̃X�P�[���Ōv�Z
		Vector2 inputRatio = joystickHandle.localPosition / maxDistance;

		// �l�������ɓn���ăC�x���g�𑗐M
		JoystickOutput?.Invoke(inputRatio);

	}
	// ���[�U�[���h���b�O����߂��t���[���ŌĂяo�����֐�
	public void OnEndDrag(PointerEventData eventData)
	{
		// �ʒu�𒆐S�Ƀ��Z�b�g����
		joystickHandle.localPosition = new Vector3();

		// �l�������ɓn���ăC�x���g�𑗐M
		JoystickOutput?.Invoke(Vector2.zero);

	}

}
// Start��Update�͕K�v�Ȃ��̂Ŏ�菜��

