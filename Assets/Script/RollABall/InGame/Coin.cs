using System.Collections;
using UnityEngine;
public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;

    private float bonusTime = 2f;
    private float disappearTime = 5f;


    private int scoreValue = 10;
    private int bonusScoreValue = 20;

    private int bigBonusScoreValue = 100;
   
    private enum bonusChance


    {



        Invalide = -1,
        BigBonus,
        SmallBinus,
        NoBonus

    }

    private bonusChance bonusChances;
    public Material CoinMaterial;
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {

        bonusChances = bonusChance.BigBonus;
        CoinMaterial.color = Color.yellow;
        yield return new WaitForSeconds(bigBonusTime);
        bonusChances = bonusChance.SmallBinus;
        CoinMaterial.color = Color.cyan;
        yield return new WaitForSeconds(bonusTime - bigBonusTime);
        bonusChances = bonusChance.NoBonus;
        CoinMaterial.color = Color.red;
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")

        {

            switch (bonusChances)


            {
                case bonusChance.BigBonus:
                    ScoreManager.ScoreCount += bigBonusScoreValue;
                                 break;

                case bonusChance.SmallBinus:
                    ScoreManager.ScoreCount += bigBonusScoreValue;
                    break;

                case bonusChance.NoBonus:
                    ScoreManager.ScoreCount += scoreValue;
                    break;

                    


            }




            Destroy(gameObject);

        }

    }


}