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

    public int life = 3;//�̗͏��
    private float hittime = 4.0f;//���G���Ԑݒ�

    [SerializeField]private bool hits;//�G�l�~�[�Ƃ̃q�b�g����

    [SerializeField] private GameObject penemy;
    [SerializeField] private GameObject lenemy;
    Collider collider;
    Collider collider2;

    // Start is called before the first frame update
    void Start()
    {
        sceneToLoad = "GameOverScene";//Load����V�[���̏����ݒ�
        collider = penemy.GetComponent<Collider>();
        collider2 = lenemy.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hits)//���G���Ԍv�Z
        {
            dtimes = Time.deltaTime;
            stimers = stimers + (dtimes % 2.2f);
            Debug.Log(stimers);
            if(stimers > 1)
            {
                collider.enabled = false;//collider�̓����蔻��𖳂���
                collider2.enabled = false;//collider2�̓����蔻��𖳂���
                if (stimers > hittime)
                {
                    stimers = 0;
                    collider.enabled = true;//collider�ɓ����蔻�������
                    collider2.enabled = true;//collider�ɓ����蔻�������
                    hits = false;
                    //collider.isTrigger = false;
                }
            }
            /*if (stimers > hittime)
            {
                stimers = 0;
                collider.enabled = true;//collider�ɓ����蔻�������
                collider2.enabled = true;//collider�ɓ����蔻�������
                hits = false;
                //collider.isTrigger = false;
            }:*/
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        
        // �G�l�~�[�Ƃ̏Փˊm�F�p�^�O
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (!hits)//hits��false�Ȃ�̗͂����炷
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
            // �V�[�����ړ�
            //SceneManager.LoadScene(sceneToLoad);
        }
        if (life == 0)//�̗͂������Ȃ�����GameOver
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
