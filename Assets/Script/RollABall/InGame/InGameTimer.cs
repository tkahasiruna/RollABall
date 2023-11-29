using UnityEngine;
using UnityEngine.UI;
public class InGameTimer : MonoBehaviour
{
    public Text TimerText;
    private float timerTime = 30f;
    void Update()
    {
        if (timerTime < 0)
        {
            TimerText.text = "0";
        }
        else
        {
            TimerText.text = $"{StringUtility.SecondsToTwoDecimalPlaces(timerTime -= Time.deltaTime)}";
        }
    }
}