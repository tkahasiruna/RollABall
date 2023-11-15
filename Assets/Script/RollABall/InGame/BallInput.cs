
using UnityEngine;
using UnityEngine.InputSystem;
public class BallInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("Wキーが押されました!");
        }
        // Wキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Wキーが押され続けてます!");
        }
        // Wキーが離された瞬間だけ評価する
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("Wキーが離されました!");
        }
    }
}