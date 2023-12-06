using UnityEngine;
using UnityEngine.InputSystem;
public class BallInput : MonoBehaviour

{
    public BallController ballController;

   



    void Update()
    {
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.isPressed)
        {
            ballController.BallMove(Vector3.forward);
        }
        // Wキーが押され続けている間
        if (Keyboard.current.aKey.isPressed)
        {
            ballController.BallMove(Vector3.left);
        }
        // Wキーが離された瞬間だけ評価する
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