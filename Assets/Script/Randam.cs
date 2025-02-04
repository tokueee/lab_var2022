using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randam : MonoBehaviour
{
    //Buttonsにアタッチ
    public bool SaveGet_rand = true;

    //Player playerscript; //呼ぶスクリプトにあだなつける
    [SerializeField] private GameObject camera;
    MouseAction mouseactionsc;

    public bool spone;
    // Start is called before the first frame update
    void Start()
    {
        mouseactionsc = camera.GetComponent<MouseAction>();
    }

    // Update is called once per frame

    private void Update()
    {
        //GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
        //playerscript = obj.GetComponent<Player>();
        //付いているスクリプトを取得
        if (mouseactionsc.checks)
        {
            if (Get_Randam(ref SaveGet_rand))
            {
                //Debug.Logランダム生成を呼び出せたことを表示する
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

    private bool Get_Randam(ref bool SaveGet_rand)//1/5の確率でtrueを返す関数
    {
        bool get_randam = false;//true=get
        //ランダムを一度止めるための変数
        int chance = 5;
        if (SaveGet_rand) {
            int randnum5 = Random.Range(0, chance);//0からchanceまでのランダム変数を生成のつもり
                                                  //Debug_log表示
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
