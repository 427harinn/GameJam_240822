using System.Collections;
using System.Collections.Generic;
using KanKikuchi.AudioManager;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    public int totalScore;
    //max904
    public int DragGameScore;

    public int clickScore;
    public string select1 = "";
    public string select2 = "";
    public string select3 = "";

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

    public void SetDragGameScore(int score)
    {
        DragGameScore = score;
    }
    private void Start()
    {
        BGMManager.Instance.Play(BGMPath.OPENING_BGM);
    }
}
