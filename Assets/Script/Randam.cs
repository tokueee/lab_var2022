using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randam : MonoBehaviour
{
    //Buttons�ɃA�^�b�`
    public bool SaveGet_rand = true;

    //Player playerscript; //�ĂԃX�N���v�g�ɂ����Ȃ���
    MouseAction mouseactionsc;

    public bool spone;
    // Start is called before the first frame update
    void Start()
    {
        mouseactionsc =GetComponent<MouseAction>();
    }

    // Update is called once per frame

    private void Update()
    {
        //GameObject obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        //playerscript = obj.GetComponent<Player>();
        //�t���Ă���X�N���v�g���擾
        if (mouseactionsc.checks)
        {
            if (Get_Randam(ref SaveGet_rand))
            {
                //Debug.Log�����_���������Ăяo�������Ƃ�\������
                spone = true;
                //Debug.Log(SaveGet_rand);
                Debug.Log("hit");
            }
        }
        else
        {
            SaveGet_rand = true;
        }
    }

    /*bool butoonjcheck(int k)
    {
        bool check = false;
        if (buttonJudgesc.button[k])
        {
            check = mouseactionsc.Buttonj1();
        }
        return check;
    }*/

    private bool Get_Randam(ref bool SaveGet_rand)//1/5�̊m����true��Ԃ��֐�
    {
        bool get_randam = false;//true=get
        //�����_������x�~�߂邽�߂̕ϐ�
        int chance = 5;
        if (SaveGet_rand) {
            int randnum5 = Random.Range(0, chance);//0����chance�܂ł̃����_���ϐ��𐶐��̂���
                                                  //Debug_log�\��
            Debug.Log("randnum =" + randnum5);
            //Debug.Log(randnum5);

            if(randnum5 == 0)
            {
                get_randam = true;
            }
            SaveGet_rand = false;
        }

        return get_randam;
    }
}
