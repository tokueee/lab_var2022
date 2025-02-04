using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MouseAction : MonoBehaviour
{
    ButtonJudge buttons;
    Battelys battelys;
    Lightset lsets;
    Global globalsm;
    [SerializeField] private GameObject lightsets;
    //[SerializeField] private GameObject Globalsc;

    [SerializeField] private Text Use;
    [SerializeField] private GameObject UseCanvas;

    private string usetext;

    private float times;
    private float stimer;
    private bool mremove = false;
    private bool flags;

    public bool checks;
    //public bool oneclick = false;

    //Boy.cs���R���|�[�l���g
    [SerializeField] private Boy boy;
    //�ȉ��ϐ�_Clear�֌W
    [SerializeField] private Clear_text Cl_txt;


    void UseText()
    {
        if(Global.language == Global.Language.Eng)
        {
            usetext = "LeftClick Use";
        }
        else
        {
            usetext = "���N���b�N �g�p";
        }
        //usetext = "LeftClick Use";
        Use.text = usetext;
    }
    // Start is called before the first frame update
    void Start()
    {
        buttons = FindObjectOfType<ButtonJudge>();
        battelys = FindObjectOfType<Battelys>();
        lsets = lightsets.GetComponent<Lightset>();
        //globalsm = Globalsc.GetComponent<Global>();

        UseText();
        UseCanvas.SetActive(false);

        //Debug.Log(buttons.button[1]);
        //Debug.Log(buttons.flag2);
    }
    //flag�n���p�̂��
    public bool flagjudge()
    {
        for(int i = 0; i < buttons.button.Length; i++)
        {
            if (buttons.flag2[i] == true)
            {
                flags = true;
                continue;
            }
        }
        /*if ((buttons.flag2[0] || buttons.flag2[1] || buttons.flag2[2]) == true)
        {
           flags = true;
        }*/
        return flags;
    }

    //flag�̌��ʂ�n��
    public bool Buttonj1(){ return buttons.flag2[0];}
    public bool Buttonj2(){ return buttons.flag2[1];}
    public bool Buttonj3() { return buttons.flag2[2]; }
    public bool Buttonj4() { return buttons.flag2[3]; }
    public bool Buttonj5() { return buttons.flag2[4]; }

    private void Buttonflag()
    {
        if (buttons.flag2[0] == true) { Buttonj1(); }
        else if (buttons.flag2[1] == true) { Buttonj2(); }
        else if (buttons.flag2[2] == true) { Buttonj3(); }
        else if (buttons.flag2[3] == true) { Buttonj4(); }
        else if (buttons.flag2[4] == true) { Buttonj5(); }
    }

    

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        /*mpos_x = Input.mousePosition.x;
        mpos_y = Input.mousePosition.y;*/
        //Debug.Log(mpos_y);
        if (Physics.Raycast(ray,out  hit ,2.5f)){
            Debug.DrawRay(ray.origin, ray.direction * 2.5f, Color.blue, 5, false);
            if(hit.collider.CompareTag("Button"))
            {
               //Debug.Log("hits");
                UseCanvas.SetActive(true);
            }
            else
            {
                UseCanvas.SetActive(false); 
            }
        }
        else
        {
            UseCanvas.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�{�^���������ꂽ����s
            /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;*/
            if (Physics.Raycast(ray, out hit,2.5f))
            {
                //buttons = hit.collider.GetComponent<ButtonJudge>();
                if (buttons != null)
                {
                    for(int h = 0; h < buttons.button.Length; h++)
                    {
                        //���C�g�̃{�^���������Ă���̂����o���邽�߂�if��
                        if (hit.collider.gameObject == buttons.button[h] && !lsets.oneclick)
                        {
                            lsets.oneclick = true;
                            //Debug.Log(lsets.oneclick);
                            buttons.Getnum(h);
                            checks = buttons.butoonjcheck(h);//Randam�Ŏg�����߂�chcks�Ɍ��ʂ�����
                            //Debug.Log(checks);
                            /*if (buttons.button[h] && buttons.flag2[h] == false)
                            {
                                buttons.flag2[h] = true;
                                //Debug.Log("good");
                            }
                            else if (buttons.button[h] && buttons.flag2[h])
                            {
                                buttons.flag2[h] = true;
                            }
                            buttons.enemyLSpot[h].color = Color.red;
                            buttons.enemyLSpotP[h].color = Color.red;*/
                        }
                        
                    }

                    if(battelys != null)
                    {
                        for (int j = 0; j < battelys.Battely.Length; j++)
                        {
                            if (hit.collider.gameObject == battelys.Battely[j])
                            {
                                battelys.Get_num(j);
                            }
                        }
                    }
                    Buttonflag();


                    flagjudge();
                   
                }
                if (hit.collider.CompareTag("friend"))//Goal�^�O�t���Ă���I�u�W�F�N�g��Ray���G�ꂽ����s
                {
                    //Debug.Log("Clear!");
                    boy.isPlayer = true;
                }
                if (hit.collider.CompareTag("Goal"))//Goal�^�O�t���Ă���I�u�W�F�N�g��Ray���G�ꂽ����s
                {
                    //Debug.Log("Clear!");
                    Cl_txt.touch_Goal = true;
                }
            }
            Debug.DrawRay(ray.origin, ray.direction*5, Color.red, 5,false);
        }

        if(Input.GetMouseButtonUp(0))
        {
            //�}�E�X�{�^�����痣�ꂽ���Ɏ��s
            for(int i = 0; i < buttons.flag2.Length; i++)
            {
                if (buttons.flag2[i] == true)
                {
                    mremove = true;
                    continue;
                }
            }
            /*if (buttons.flag2[0] || buttons.flag2[1])
            {
                mremove = true;
                //buttons.flag2[0] = false ;
             }*/
        }
        
        if (mremove)
        {
            times = Time.time;
            stimer = times % 10.1f;
            //Debug.Log(stimer);
            if(stimer > 10)
            {
                mremove = false;
                checks = false;
                //false�ɂ��Ď��̎��s�ɔ�����
                for(int flag = 0; flag < buttons.flag2.Length; flag++)
                {
                    buttons.flag2[flag] = false;
                }

            }
        }
        
    }
}
