using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
	[Tooltip("タイマーが開始してからの時間"), SerializeField]
	private float elapsedTime;

	[Tooltip("タイマーの持続時間"), SerializeField]
	private float duration;

	[Tooltip("パーセンテージで出力する値"), SerializeField]
	private bool percentage;

	[System.Serializable]
	public class FloatUnityEvent : UnityEvent<float> { }

	[Tooltip("パーセンテージで処理される値"), SerializeField]
	public FloatUnityEvent elapsedTimeUpdated;

	[Tooltip("時間が切れると呼び出される"), SerializeField]
	public UnityEvent completed;


// bool name  = true パーセンテージによる値をデフォルトに設定
// GetProgress()と記述するのはGetProgress(true)を意味します
public float GetProgress(bool asPercentage = true)
{
	// 保存された値
	float result;

	// パーセンテージ、または経過時間
	if (asPercentage)
	{
		result = elapsedTime / duration;
	}
	else
	{
		result = elapsedTime;
	}

	// 最大値内に収める 
	return Mathf.Clamp(result, 0, asPercentage ? 1 : duration);

}


	public IEnumerator PerformTimeCheck()
	{

		// 条件が真である限り実行
		while (elapsedTime < duration)
		{
			// 各ループがフレームの終わりまで待つよう強制
			yield return new WaitForEndOfFrame();

			// 経過時間を更新 
			elapsedTime += Time.deltaTime;

			// リスナーにelapsedTimeが更新されたことを通知 
			elapsedTimeUpdated?.Invoke(GetProgress(percentage));
		}

		// リスナーに時間終了を通知
		completed?.Invoke();



	}

	public void ResetTime()
	{
		elapsedTime = 0;
		elapsedTimeUpdated.Invoke(GetProgress(percentage));
	}

	public void StartTimer()
	{
		StopAllCoroutines();
		StartCoroutine(PerformTimeCheck());
	}

	public void RestartTimer()
	{
		// 時間を0にリセットし、サブスクライバに通知
		ResetTime();

		// タイマーを開始
		StartTimer();
	}
}











