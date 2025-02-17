using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //Directional Light Rotation X = -15
    //S_,二階ライト　T_.三階ライト
    [SerializeField] private GameObject[] firstfloorlight_h;//一階廊下
    [SerializeField] private GameObject[] firstfloorlight;//一階室内    
    [SerializeField] private GameObject[] secondfloorlight_h;//二階廊下
    [SerializeField] private GameObject[] secondfloorlight;//二階室内
    [SerializeField] private GameObject[] thirdfloorlight_h;//三階廊下
    [SerializeField] private GameObject[] thirdfloorlight;//三階室内

    SwichButton Swichb;
    MouseAction mactions;
    [SerializeField] private GameObject swichb;

    // Start is called before the first frame update
    void Start()
    {
        Swichb = swichb.GetComponent<SwichButton>();
        mactions = swichb.GetComponent<MouseAction>();
        Lightseting();
    }

    void Lightseting()
    {
        for (int i = 0; i < firstfloorlight.Length; i++)
        {
            firstfloorlight[i].SetActive(false);
        }
        for (int i = 0;i < secondfloorlight.Length; i++)
        {
            secondfloorlight[i].SetActive(false);
        }
        for(int i = 0; i <thirdfloorlight.Length; i++)
        {
            thirdfloorlight[i].SetActive(false);
        }
    }

    void SwichLightOn()
    {
        Debug.Log("ON");
        for(int i = 0; i < Swichb.Sbutton.Length; i++)
        {
            //ライトのつけ消しを制御するスクリプト
            if (Swichb.Sflag[i] == true && firstfloorlight[i].activeSelf == false && mactions.count[i] == 1)
            {
                firstfloorlight[i].SetActive(true);
                Swichb.changemate(i);
            }
            else if (Swichb.Sflag[i] == false && firstfloorlight[i].activeSelf == true && mactions.count[i] == 0)
            {
                firstfloorlight[i].SetActive(false);
                //Swichb.Sflag[i] = false;
                Swichb.changemate(i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Swichb.Swichjudge() == true) { SwichLightOn(); }//いずれかのSflagがtrueの時だけ実行させる
    }
}
