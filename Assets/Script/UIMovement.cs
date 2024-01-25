using UnityEngine;

public class UIMovement : MonoBehaviour
{
	// UIの現在の速さ
	public float speed = 100;

	// ゲームオブジェクトから取得した現在の向き
	public Vector3 currentDirection;


	// 指が画面上でドラッグされるたびに呼び出される関数
	public void MoveDirection(Vector2 moveValue)
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

