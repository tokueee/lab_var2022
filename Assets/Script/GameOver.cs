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

    public int life = 3;//体力上限
    private float hittime = 4.0f;//無敵時間設定

    private bool hits;//エネミーとのヒット判定

    // Start is called before the first frame update
    void Start()
    {
        sceneToLoad = "GameOverScene";//Loadするシーンの初期設定
    }

    // Update is called once per frame
    void Update()
    {
        if (hits)//無敵時間計算
        {
            dtimes = Time.deltaTime;
            stimers = stimers + (dtimes % 2.2f);
            Debug.Log(stimers);
            if (stimers > hittime)
            {
                stimers = 0;
                hits = false;
            }
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
                Debug.Log(life);
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
