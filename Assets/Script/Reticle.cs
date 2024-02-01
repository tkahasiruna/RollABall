using UnityEngine;

public class Reticle : MonoBehaviour
{
	[Tooltip("�g�����X�t�H�[���𑀍삷��")]
	public Transform controller;

	[Tooltip("�ʒu�ƌ����������ōX�V�����̂�h��")]
	private bool overrideAutomatedUpdate;

	public bool OverrideAutomatedUpdate
	{
		set
		{
			overrideAutomatedUpdate = value;
		}
	}

	[SerializeField, Tooltip("�q�b�g�n�_�ɃI�[�o�[���C���鋗��")]
	private float distanceFromHit = 0.05f;

	[SerializeField, Tooltip("�ʏ펞�̖ڂ���̋���")]
	private float restingDistance = 2f;

	[SerializeField, Tooltip("�O�������𔽓]������")]
	private bool invertForward;


	// �c. ����܂ł̃t�B�[���h�A�C�x���g�A���\�b�h

	// �Q�[���I�u�W�F�N�g�����[�U�[�̐��ʂɔz�u
	public void AutoPositionOrientation()
	{
		transform.position =
controller.position + controller.forward * restingDistance;


		transform.forward =
		(invertForward ? -1 : 1) * controller.forward;

	}
	public void LateUpdate()
	{
		if (!overrideAutomatedUpdate)
		{
			AutoPositionOrientation();





		}



	}


	// ���e�B�N���̑O��������ݒ�
	public void SetForward(Vector3 forward)
	{
		transform.forward = (invertForward ? -1 : 1) * forward;
	}

	public void SetPosition(Vector3 position)
	{
		transform.position = position + (invertForward ? -1 : 1)
	* transform.forward * distanceFromHit;
	}

}










