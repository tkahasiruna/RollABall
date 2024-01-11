using UnityEngine;
using UnityEngine.Events;

public class UnityEventPublisher : MonoBehaviour
{
    // リアクションを引き起こすイベント
    public UnityEvent Published;

    // イベントをトリガーするメソッド
    public void Publish()
    {
        Published?.Invoke();
    }
}

