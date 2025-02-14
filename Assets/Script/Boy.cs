using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boy : MonoBehaviour
{
    [SerializeField] private GameObject Player_obj;
    [SerializeField] private GameObject Player_space;
    [SerializeField] private GameObject Only_My;
    [SerializeField] private GameObject With_Friend;//������ɒǉ������v�f

    private NavMeshAgent navMeshAgent;

    [SerializeField] private float Delaytime;

    public bool isPlayer = false;
    private Transform boystarget;
    private bool only = true;//�ŏ��������s���Ăق����v���O�����̊Ǘ�
    private bool come_on = true;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //StartCoroutine(Delay());
    }

    private void OnTriggerEnter(Collider other)//���̋����ɋ߂Â�����~�܂�
    {
        if (other.gameObject == Player_space)
        {
            come_on = false;
        }
    }
    private void OnTriggerStay(Collider other)//���̋����ɋ߂Â�����~�܂�
    {
        if (other.gameObject == Player_space)
        {
            come_on = false;
        }
    }
    private void OnTriggerExit(Collider other)//���̋����ɋ߂Â�����~�܂�
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
                    //Debug.Log("�X�^�[�g");
                    yield return new WaitForSeconds(Delaytime);
                    if (Player.keyCount != 0 || only == true)
                    {
                        navMeshAgent.destination = Player_obj.transform.position;
                    }
                    only = false;

                }
                {
                    yield return null; // isPlayer��false�̊Ԃ͑ҋ@
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
                //Debug.Log("�X�^�[�g");
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
