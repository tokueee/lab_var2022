using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boy : MonoBehaviour
{
    [SerializeField] private GameObject Player_obj;
    [SerializeField] private GameObject Player_space;
    [SerializeField] private GameObject Only_My;
    [SerializeField] private GameObject With_Friend;//合流後に追加される要素

    private NavMeshAgent navMeshAgent;

    [SerializeField] private float Delaytime;

    public bool isPlayer = false;
    private Transform boystarget;
    private bool only = true;//最初だけ実行してほしいプログラムの管理
    private bool come_on = true;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //StartCoroutine(Delay());
    }

    private void OnTriggerEnter(Collider other)//一定の距離に近づいたら止まる
    {
        if (other.gameObject == Player_space)
        {
            come_on = false;
        }
    }
    private void OnTriggerStay(Collider other)//一定の距離に近づいたら止まる
    {
        if (other.gameObject == Player_space)
        {
            come_on = false;
        }
    }
    private void OnTriggerExit(Collider other)//一定の距離に近づいたら止まる
    {
        if (other.gameObject == Player_space)
        {
            come_on = true;
        }
    }

    // Update is called once per fram
    /*public IEnumerator Delay()
    {
        while(true){
            while(come_on)
            {
                if (isPlayer == true)
                {
                    //Debug.Log("スタート");
                    yield return new WaitForSeconds(Delaytime);
                    if (Player.keyCount != 0 || only == true)
                    {
                        navMeshAgent.destination = Player_obj.transform.position;
                    }
                    only = false;

                }
                {
                    yield return null; // isPlayerがfalseの間は待機
                }
            }
            Debug.Log("END");
            navMeshAgent.destination = transform.position;
            yield return null;
        }

    */

    private void Update()
    {
        //while (come_on)
        {
            if (isPlayer == true)
            {
                //Debug.Log("スタート");
                //yield return new WaitForSeconds(Delaytime);
                if (Player.keyCount != 0 || only == true)
                {
                    navMeshAgent.destination = Player_obj.transform.position;
                }
                only = false;

            }
        }
        //Debug.Log("END");
        if (!come_on) { navMeshAgent.destination = transform.position; }
        //yield return null;


        With_Friend.SetActive(isPlayer);
        Only_My.SetActive(!isPlayer);
    }

}
