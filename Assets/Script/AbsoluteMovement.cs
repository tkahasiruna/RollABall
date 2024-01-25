using UnityEngine;

public class AbsoluteMovement : MonoBehaviour
{
	// UIの現在の速さ
	public float speed = 1;

	// ゲームオブジェクトから取得した現在の向き
	public Vector3 currentDirection;


	// v.x = cd.x、v.y = cd.yに方向を設定
	public void MoveDirectionXZ(Vector2 moveValue)
	{
		// 位置を中心にリセットする
		currentDirection = new Vector3(moveValue.x, 0, moveValue.y);
	}

	// v.x = cd.x、v.y = cd.zに方向を設定
	public void MoveDirectionXY(Vector2 moveValue)
	{
		// 位置を中心にリセットする
		currentDirection = moveValue;
	}

	public void Update()
	{
		// トランスフォームを現在の向きの方へ設定されたスピードで移動
		transform.position += currentDirection * speed * Time.deltaTime;
	}
}

