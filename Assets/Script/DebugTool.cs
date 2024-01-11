using UnityEngine;

public class DebugTool : MonoBehaviour
{

	// プレイヤーの年齢を表示
	public void PrintPlayerAge()
	{
		Debug.Log(PlayerManager.Instance.playerAge);
	}
}
