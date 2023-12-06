using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinMaker : MonoBehaviour
{
    public GameObject Coin;
    private float makeTime = 5f;
    void Start()
    {
        StartCoroutine(CoinMekeByTime());
    }
    IEnumerator CoinMekeByTime()
    {
        yield return new WaitForSeconds(makeTime);
        Instantiate(Coin, new Vector3(-3f, -3.5f, 0f), Quaternion.Euler(new Vector3(90, 0, 0)));
    }
}