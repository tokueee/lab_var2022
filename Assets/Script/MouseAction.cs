using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction : MonoBehaviour
{
    //�}�E�X��X���W
    /*private float mpos_x;
    private float mposmax_x = 680;
    private float mposmin_x = 600;
    
    //�}�E�X��Y���W
    private float mpos_y;
    private float mposmax_y = 410;
    private float mposmin_y = 320;*/
    ButtonJudge buttons;
    Battelys battelys;
    Lightset lsets;
    [SerializeField] private GameObject lightsets;

    private float times;
    private float stimer;
    private bool mremove = false;
    private bool flags;

    public bool checks;
    //public bool oneclick = false;

    // Start is called before the first frame update
    void Start()
    {
        buttons = FindObjectOfType<ButtonJudge>();
        battelys = FindObjectOfType<Battelys>();
        lsets = lightsets.GetComponent<Lightset>();

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
        /*mpos_x = Input.mousePosition.x;
        mpos_y = Input.mousePosition.y;*/
        //Debug.Log(mpos_y);
        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�{�^���������ꂽ����s
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,5.0f))
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
                    /*for (int j = 0; j < battelys.Battely.Length; j++)
                    {
                        if (hit.collider.gameObject == battelys.Battely[j])
                        {
                            battelys.Get_num(j);
                        }
                    }*/
                    Buttonflag();

                    //��
                    {
                        /*if (buttons.flag2[0] == true) { Buttonj1(); }
                        else if (buttons.flag2[1] == true) { Buttonj2(); }
                        else if (buttons.flag2[2] == true) { Buttonj3(); }
                        else if (buttons.flag2[3] == true) { Buttonj4(); }
                        else if (buttons.flag2[4] == true) { Buttonj5(); }*/
                        /*if (hit.collider.gameObject == buttons.button[0])
                        {
                            if (buttons.button[0] && buttons.flag2[0] == false)
                            {
                                buttons.flag2[0] = true;
                                //Debug.Log("good");
                            }
                            else if (buttons.button[0] && buttons.flag2[0])
                            {
                                buttons.flag2[0] = true;
                            }
                            Buttonj1();
                        }
                        if (hit.collider.gameObject == buttons.button[1])
                        {
                            if (buttons.button[1]  && buttons.flag2[1] == false)
                            {
                                buttons.flag2[1] = true;
                            }
                            else if (buttons.button[1] && buttons.flag2[1])
                            {
                                buttons.flag2[1] = true;
                            }
                            Buttonj2();
                        }

                        if (hit.collider.gameObject == buttons.button[2])
                        {
                            if (buttons.button[2] && buttons.flag2[2] == false)
                            {
                                buttons.flag2[2] = true;
                            }
                            else if (buttons.button[2] && buttons.flag2[2])
                            {
                                buttons.flag2[2] = true;
                            }
                            Buttonj3();
                        }

                        if (hit.collider.gameObject == buttons.button[3])
                        {
                            if (buttons.button[3] && buttons.flag2[3] == false)
                            {
                                buttons.flag2[3] = true;
                            }
                            else if (buttons.button[3] && buttons.flag2[3])
                            {
                                buttons.flag2[3] = true;
                            }
                            Buttonj4();
                        }

                        if (hit.collider.gameObject == buttons.button[4])
                        {
                            if (buttons.button[4] && buttons.flag2[4] == false)
                            {
                                buttons.flag2[4] = true;
                            }
                            else if (buttons.button[4] && buttons.flag2[4])
                            {
                                buttons.flag2[4] = true;
                            }
                            Buttonj4();
                        }*/
                    }

                    flagjudge();
                   
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
        /*if (mpos_x >= mposmin_x && mpos_y >= mposmin_y && mpos_x <= mposmax_x && mpos_y <= mposmax_y)
        {
            //Debug.Log(Input.mousePosition);
            if (players != null)
            {
                Debug.Log(hit.collider.transform.position);
            }
        }*/
        
    }
}
