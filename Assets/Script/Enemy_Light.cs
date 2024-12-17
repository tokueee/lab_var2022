using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.PlayerSettings;
public class Enemy_Light : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Player_Light playercs;

    [SerializeField]
    private Transform Startpotision;

   // [SerializeField]
   // private float Speed;

    private NavMeshAgent navMeshAgent;

    private Vector3 targetPosition;

    private Vector3 Enemy_Position; // �G�̏����ʒu

    /*
    //LightEnemy�̍��W�擾�p
    [SerializeField] private GameObject Lenemy;

    //�X�N���v�g�擾�p
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject Cnoise2;//Script�擾�p
    [SerializeField] private CameraNoise noises;

    //�����v�Z��̑���p
    private float distans;

    //�m�C�Y�̓��ߓx�̒l
    private float lmax = 0.1f;
    private float lightmin_c = 0.08f;
    private float lmid = 0.06f;
    private float lmin = 0.04f;

    //�����p�̕ϐ�
    private float cdists = 10.0f;
    private float mdists = 20.0f;
    private float fcdists = 30.0f;
    private float fdists2 = 40.0f;

    //�����ɉ����ĕԂ��֐�
    private int DisNum2(float dist)
    {
        if (dist < cdists) return 0;
        if (dist < mdists) return 1;
        if (dist < fcdists) return 2;
        if (dist < fdists2) return 3;
        return 4;
    }

    //�����ɉ����ăm�C�Y�̋�����ς���֐�
    private void Dtrans2(float distnum)
    {

        switch (distnum)
        {
            //disnum�̒l�ɉ����Ď��s����
            case 0:
                noises.SecondsetTrans(lmax);
                noises.enabled = true; break;
            case 1:
                noises.SecondsetTrans(lightmin_c);
                noises.enabled = true; break;
            case 2:
                noises.SecondsetTrans(lmid);
                noises.enabled = true; break;
            case 3:
                noises.SecondsetTrans(lmin);
                noises.enabled = true; break;
            case 4:
                noises.SecondsetTrans(0.0f);
                noises.enabled = true; break;
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playercs = player.GetComponent<Player_Light>();
        //noises = Cnoise2.GetComponent<CameraNoise>();
        Enemy_Position = Startpotision.transform.position;
        //  navMeshAgent.destination = Goal[destNum].position;
    }

    // Update is called once per frame
    void Update()
    {
        /*distans = Vector3.Distance(Lenemy.transform.position,player.transform.position);
        int inum = DisNum2(distans);//�����ɉ����ĕԂ��֐��Ăяo��
        //Debug.Log(inum);
        Dtrans2(inum);//�����ɉ����ăm�C�Y�̋�����ς���֐��Ăяo��
        */
        //navMeshAgent.speed = Speed;
        // MoveTarget();
        if (playercs.Lightcheck())
        {     
          // DirectionToPosition = DirectionToPosition.normalized;
            // navMeshAgent.isStopped = false;
            navMeshAgent.destination = player.transform.position;
            
        }
        else
        {
            // navMeshAgent.isStopped = true;

            navMeshAgent.destination = Startpotision.position;
        }
    }
    private void MoveTarget()
    {

        //������ς���
        Vector3 DirectionToTarget = (targetPosition - transform.position).normalized;
        float DistanceToPlayer = DirectionToTarget.magnitude;
        DirectionToTarget = DirectionToTarget.normalized;

        Quaternion LookRotation = Quaternion.LookRotation(DirectionToTarget);
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5.0f); // ��]���x�𒲐�

        //transform.position += DirectionToTarget * Speed * Time.deltaTime;
    }
}


