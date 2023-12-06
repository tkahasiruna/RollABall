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
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {

        bonusChances = bonusChance.BigBonus;
        yield return new WaitForSeconds(bigBonusTime);
        bonusChances = bonusChance.SmallBinus;
        yield return new WaitForSeconds(bonusTime - bigBonusTime);
        bonusChances = bonusChance.NoBonus;
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