
using UnityEngine;
using UnityEngine.InputSystem;
public class BallInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }
        // W�L�[�������ꑱ���Ă����
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W�L�[�������ꑱ���Ă܂�!");
        }
        // W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }
    }
}