using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonJudge : MonoBehaviour
{
    MouseAction action;

    //[SerializeField] private GameObject Prand;//Player������
    public GameObject[] button;
    public bool[] flag2;
    public Light[] enemyLSpot;
    public Light[] enemyLSpotP;
    /*
    [0] =Spot LightN
    [1] =Spot Light(4)
    [2] =Spot Light(9)
    [3] =Spot Light(12)R
     */
    void Start()
    {
        action = GetComponent<MouseAction>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool Getnum(int h)
    {
        //Debug.Log(ran.spone);
        if (button[h] && flag2[h] == false)
        {
            flag2[h] = true;
            //Debug.Log("good");
        }
        else if (button[h] && flag2[h])
        {
            flag2[h] = true;
        }
        return flag2[h];
        /*if (ran.spone)
        {
            enemyLSpot[h].color = Color.red;
            enemyLSpotP[h].color = Color.red;
        }*/
    }
    /*public void buttonColor(int i)
    {
        button[i].GetComponent<MeshRenderer>().materials[0].color = Color.white;
    }*/
    public bool butoonjcheck(int k)
    {

        bool check = false;
        switch (k)
        {
            case 0: check = flag2[0]; break;
            case 1: check = flag2[1]; break;
            case 2: check = flag2[2]; break;
            case 3: check = flag2[3]; break;
            case 4: check = flag2[4]; break;
        }
        //Buttonj1�`5�����ꂩ��flag��check�ɓ���ĕԂ�
        return check;
    }
}
