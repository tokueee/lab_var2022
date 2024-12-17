using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSE : MonoBehaviour
{

    public AudioClip[] leg;
    //public AudioClip souns;
    private AudioSource audioSource;


    private GameObject obj; //Player���Ă����I�u�W�F�N�g��T��
    private Player PlayerCS; //�ĂԃX�N���v�g�ɂ����Ȃ���

    public float Savetime; //�f�o�b�O�p�̕\�����ꂽ�����łǂꂮ�炢�̕p�x�ōĐ����邩�̌Œ�l
    private float PbTime;//Playback Time(�Đ�����)
    private float checktime;
    private bool wait;


    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();

        obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        PlayerCS = obj.GetComponent<Player>();

        wait = false;
    }

    void Update()
    {
        if (PlayerCS.key_Shift)
        {
            PbTime = Savetime * 0.8f;
        }
        else 
        {
            PbTime = Savetime;
        }
        if (PlayerCS.keyCount != 0)
        {
            if (wait)
            {
                checktime = Time.time;
            }
            //��(sound)��炷
            if (PbTime >= Time.time - checktime && wait)
            {
                
                Get_Sound();
                wait = false;
                Debug.Log("Get_Sounds");
            }
        }
        if (PlayerCS.keyCount == 0 || PbTime < Time.time - checktime)
        {
            wait = true;
        }
        
    }

    private void Get_Sound()//1/25�̊m����true��Ԃ��֐�
    {
        //�����_������x�~�߂邽�߂̕ϐ�
        int chance = 25;
        //0����chance-1�܂ł̃����_���ŉ�����I��ŕԂ��B
        audioSource.PlayOneShot(leg[Random.Range(0, chance)]);
    }
}