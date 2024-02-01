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
	// �Ώۂ̃Q�[���I�u�W�F�N�g��EventTrigger������ꍇ�N���b�N 
	public void PerformClick()
	{
		if (!hoveredObject)
		{
			return;
		}

		// IPointerClickHandler���g�p���ăI�u�W�F�N�g�̃N���X���擾
		IPointerClickHandler clickHandler =
	hoveredObject.GetComponent<IPointerClickHandler>();

		// EventSYstem��������擾
		PointerEventData data =
		new PointerEventData(EventSystem.current);

		// ���̃I�u�W�F�N�g�ɃN���b�N�A�N�V���������s
		clickHandler?.OnPointerClick(data);

	}
}

