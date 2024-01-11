using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{
	public UnityEventPublisher publisher;
	public string debugMessage;

	public void OnEnable()
	{
		// サブスクライブ
		publisher?.Published.AddListener(DebugResponse);
	}

	public void OnDisable()
	{
		// サブスクリプション解除
		publisher?.Published.RemoveListener(DebugResponse);
	}

	public void DebugResponse()
	{
		Debug.Log("Unity Event: " + debugMessage);
	}
}

