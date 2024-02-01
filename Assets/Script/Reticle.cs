using UnityEngine;

public class Reticle : MonoBehaviour
{
	[Tooltip("トランスフォームを操作する")]
	public Transform controller;

	[Tooltip("位置と向きが自動で更新されるのを防ぐ")]
	private bool overrideAutomatedUpdate;

	public bool OverrideAutomatedUpdate
	{
		set
		{
			overrideAutomatedUpdate = value;
		}
	}

	[SerializeField, Tooltip("ヒット地点にオーバーレイする距離")]
	private float distanceFromHit = 0.05f;

	[SerializeField, Tooltip("通常時の目からの距離")]
	private float restingDistance = 2f;

	[SerializeField, Tooltip("前方方向を反転させる")]
	private bool invertForward;


	// …. これまでのフィールド、イベント、メソッド

	// ゲームオブジェクトをユーザーの正面に配置
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


	// レティクルの前方方向を設定
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










