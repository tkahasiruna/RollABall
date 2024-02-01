using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

public class ImageTracker : MonoBehaviour
{
	// ARTRackedImageManager�I�u�W�F�N�g
	public ARTrackedImageManager manager;

	// �������������Q�[���I�u�W�F�N�g�̃��X�g 
	public List<GameObject> targets;

	public void OnEnable()
	{
		manager.trackedImagesChanged += Reader;
	}

	public void OnDisable()
	{
		manager.trackedImagesChanged -= Reader;
	}

	public void Reader(ARTrackedImagesChangedEventArgs arg)
	{
		foreach (ARTrackedImage trackedImage in arg.added)
		{
			EnableGameObject(trackedImage.referenceImage.name);
		}

		foreach (ARTrackedImage trackedImage in arg.updated)
		{
			PositionGameObject(trackedImage.referenceImage.name,
trackedImage.transform.position);
		}

		foreach (ARTrackedImage trackedImage in arg.removed)
		{

		}
	}


public void EnableGameObject(string refName)
{
	GameObject targetGameObject = targets.Find
(item => item.name == refName);

	targetGameObject.SetActive(true);
}

// �Q�Ɩ��ƈ�v����Q�[���I�u�W�F�N�g��z�u
public void PositionGameObject(string refName, Vector3 pos)
{
	GameObject targetGameObject = targets.Find
(item => item.name == refName);

	targetGameObject.transform.position = pos;
}
}



