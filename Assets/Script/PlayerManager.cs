using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{


    // Define the function template accepted by this event�@�i���̃C�x���g�Ɏ󂯎����֐��e���v���[�g���`����j
    public static PlayerManager Instance { get; internal set; }

    // �v���C���[�̖��O
    public string playerName;

    // �v���C���[�̔N��
    public int playerAge;

    // �C���X�^���X���Z�b�g�A�b�v
    public void Awake()
    {
        if (!Instance)
        {
            Instance = this;

            // �V�[�����܂������Ă��V���O���g�����ێ�����
            DontDestroyOnLoad(this);
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
    }


    
// �c���O�c //

// ���X�i�[�ɍX�V�����������Ƃ�ʒm����C�x���g
public UnityEvent nameUpdated;

    // �v���C���[���̕ύX���\�ɂ���
    public string PlayerName
    {
        set
        {
            playerName = value;
            nameUpdated?.Invoke();
        }
    }
}




