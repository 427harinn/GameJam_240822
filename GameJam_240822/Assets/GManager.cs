using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    public int totalScore;

    public int select1 = 0;
    public int select2 = 0;
    public int select3 = 0;

    public int mixScore = 0;
    public int stageIndex = -1;  //�����_���Z���N�g���̃X�e�[�W�ԍ�, StageRandomSelect�Ŏg�p

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }


    }


}