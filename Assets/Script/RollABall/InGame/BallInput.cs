using UnityEngine;
using UnityEngine.InputSystem;
public class BallInput : MonoBehaviour

{
    public BallController ballController;

   



    void Update()
    {
        // �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.isPressed)
        {
            ballController.BallMove(Vector3.forward);
        }
        // W�L�[�������ꑱ���Ă����
        if (Keyboard.current.aKey.isPressed)
        {
            ballController.BallMove(Vector3.left);
        }
        // W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.sKey.isPressed)
        {
            ballController.BallMove(Vector3.back);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            ballController.BallMove(Vector3.right);
        }

       

    }
}