using UnityEngine;
using UnityEngine.UI;

public class TouchCountTracker : MonoBehaviour
{
    public Text textField;

    private void Update()
    {
        textField.text = Input.touchCount.ToString();
    }
}


