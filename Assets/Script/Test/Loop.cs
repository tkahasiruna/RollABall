using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ForLoop();
    }
    void ForLoop()
    {
        /* for(初期化(Initialize);条件(Condition);更新(Update))
        * 初期化: forループのループを管理するための変数などを初期化する
        * 条件: ここに書かれている条件がtrueの場合、for以下のコードを実行する
        * 更新: 処理が1セット終わった後に、ループを管理するための変数などを更新する
        */
        Debug.Log("1～100まで数えます");
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("forループを終了します");
    }
}


