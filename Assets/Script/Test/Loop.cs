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
        /* for(������(Initialize);����(Condition);�X�V(Update))
        * ������: for���[�v�̃��[�v���Ǘ����邽�߂̕ϐ��Ȃǂ�����������
        * ����: �����ɏ�����Ă��������true�̏ꍇ�Afor�ȉ��̃R�[�h�����s����
        * �X�V: ������1�Z�b�g�I�������ɁA���[�v���Ǘ����邽�߂̕ϐ��Ȃǂ��X�V����
        */
        Debug.Log("1�`100�܂Ő����܂�");
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("for���[�v���I�����܂�");
    }
}


