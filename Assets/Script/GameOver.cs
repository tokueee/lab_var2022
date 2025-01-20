using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    private float dtimes;
    private float stimers;

    private float hdtime;
    private float htime;

    public int life = 3;//体力上限
    private float hittime = 4.0f;//無敵時間設定

    [SerializeField]private bool hits;//エネミーとのヒット判定

    [SerializeField] private GameObject penemy;
    [SerializeField] private GameObject lenemy;
    Collider collider;
    Collider collider2;

    // Start is called before the first frame update
    void Start()
    {
        sceneToLoad = "GameOverScene";//Loadするシーンの初期設定
        collider = penemy.GetComponent<Collider>();
        collider2 = lenemy.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hits)//無敵時間計算
        {
            dtimes = Time.deltaTime;
            stimers = stimers + (dtimes % 2.2f);
            Debug.Log(stimers);
            if(stimers > 1)
            {
                collider.enabled = false;//colliderの当たり判定を無くす
                collider2.enabled = false;//collider2の当たり判定を無くす
                if (stimers > hittime)
                {
                    stimers = 0;
                    collider.enabled = true;//colliderに当たり判定をつける
                    collider2.enabled = true;//colliderに当たり判定をつける
                    hits = false;
                    //collider.isTrigger = false;
                }
            }
            /*if (stimers > hittime)
            {
                stimers = 0;
                collider.enabled = true;//colliderに当たり判定をつける
                collider2.enabled = true;//colliderに当たり判定をつける
                hits = false;
                //collider.isTrigger = false;
            }:*/
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        
        // エネミーとの衝突確認用タグ
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (!hits)//hitsがfalseなら体力を減らす
            {
                life--;
                //Debug.Log(life);
                hits = true;
            }
                /*dtimes = Time.deltaTime;
                stimers = stimers + (dtimes % 2.2f);
                if(stimers > 2.0f)
                {
                    hits = false;
                }*/
            // シーンを移動
            //SceneManager.LoadScene(sceneToLoad);
        }
        if (life == 0)//体力が無くなったらGameOver
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
