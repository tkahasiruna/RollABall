using UnityEngine;
using UnityEngine.Events;

public class VRRaycaster : MonoBehaviour
{
    [Tooltip("The layers considered as valid targets")]
    public LayerMask layerMasks;



    [Tooltip("maximum detection distance")]
    public float distance;


    [Tooltip("Game object currently being hit")]
    private GameObject hitGameObject;

    [System.Serializable]
    public class GameObjectUnityEvent :
UnityEvent<GameObject>
    { }

    [Tooltip("Event when hovering a target passed as argument")]
    public GameObjectUnityEvent hitTarget;
    [System.Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }

    [Tooltip("Information relative to a hit 3D properties")]
    public Vector3UnityEvent hitPosition, hitAngle;

    [Tooltip("Event sent when no longer over a target")]
    public UnityEvent stopHittingTarget;

 	// ��قǂ܂ł̑�����
public void Raycast()
    {
        // �J�������N�_�ɑO���֐i�ތ������쐬
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        Physics.Raycast(ray, out hitInfo, distance, layerMasks);

        bool hasHit =
            Physics.Raycast(ray, out hitInfo, distance, layerMasks);

        // ���������ꍇ���������ΏۂɊ֘A����C�x���g���X�V
        if (hasHit)
        {
            if (hitGameObject != hitInfo.transform.gameObject)
            {
                hitGameObject = hitInfo.transform.gameObject;
                hitTarget?.Invoke(hitGameObject);

                Debug.Log(hitInfo.transform.gameObject.name);

            }
            hitAngle?.Invoke(hitInfo.normal);
            hitPosition?.Invoke(hitInfo.point);
        }
        
else if (hitGameObject)
        {
            // hoveredObject = null;
            stopHittingTarget?.Invoke();

        }

    }


    private void Update()
    {
        Raycast();
    }


}














