using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    int[] testScores = new int[5];

    // Start is called before the first frame update

    List<int> testNum = new List<int>();

    void Start()
    {

        // �z��ɓ_������
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;
        Debug.Log(testScores[1]); // 90


        int[] numbers = { 5, 8, 12, 7, 3 };
        Debug.Log(numbers[2]);

        testNum.Add(1); // ���X�g��0�Ԗڂ̗v�f��1��ǉ�(1)
        testNum.Add(2); // ���X�g��1�Ԗڂ̗v�f��2��ǉ�(1, 2)
        testNum.Add(3); // ���X�g��2�Ԗڂ̗v�f��3��ǉ�(1, 2, 3)
        Debug.Log(testNum[0]); //���X�g�̍ŏ��̗v�f���擾(1)
        testNum.Remove(2); // ���X�g���̈�v����v�f���폜(1, 3)
        Debug.Log(testNum.Count); // ���X�g�̗v�f�����擾(���̏ꍇ�A2)

        List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int listNumber in listNumbers)

        {



            Debug.Log(listNumbers);


        }



    }




    // Update is called once per frame
    void Update()
    {
        
    }


}
