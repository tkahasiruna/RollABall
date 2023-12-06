using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;
    public static int ScoreCount = 0;

    private void Update()
    {

        ScoreText.text = ScoreCount.ToString();
    }

}
