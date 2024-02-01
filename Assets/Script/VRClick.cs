using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class VRClick : MonoBehaviour
{
	[SerializeField, Tooltip("Currently object being hovered over")]
	private GameObject hoveredObject;

	[Tooltip("Event notifying the user of a new hovered game obejct")]
	public UnityEvent newHoveredObject;

	[Tooltip("Hovered object has exited the selection")]
	public UnityEvent hoveredObjectExited;

	public void ProcessHoveredAsset(GameObject asset)
	{
		if (hoveredObject != asset)
		{
			hoveredObject = asset;
			newHoveredObject.Invoke();
		}
	}

	public void StoppedHovering()
	{
		hoveredObject = null;
		hoveredObjectExited.Invoke();
	}
	// 対象のゲームオブジェクトにEventTriggerがある場合クリック 
	public void PerformClick()
	{
		if (!hoveredObject)
		{
			return;
		}

		// IPointerClickHandlerを使用してオブジェクトのクラスを取得
		IPointerClickHandler clickHandler =
	hoveredObject.GetComponent<IPointerClickHandler>();

		// EventSYstemから情報を取得
		PointerEventData data =
		new PointerEventData(EventSystem.current);

		// このオブジェクトにクリックアクションを実行
		clickHandler?.OnPointerClick(data);

	}
}

