using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MouseAction : MonoBehaviour
{
    ButtonJudge buttons;
    SwichButton swichbuttons;
    Battelys battelys;
    Lightset lsets;
    Global globalsm;
    private GameObject lightsets;
    [SerializeField] private GameObject Globalsc;

    [SerializeField] private Text Use;
    [SerializeField] private GameObject UseCanvas;
    private GameObject swichbt;

    private string usetext;

    private float times;
    private float stimer;
    private bool mremove = false;
    private bool flags;

    public bool checks;
    public int[] count;
    //public bool oneclick = false;

    void UseText()
    {
        if(globalsm.GetLanguage() == Global.Language.Eng)
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
        if (SceneManager.GetActiveScene().name == "LIghtSampleScene")
        {
            lightsets = GameObject.Find("LIGHT");
            lsets = lightsets.GetComponent<Lightset>();
        }
        buttons = FindObjectOfType<ButtonJudge>();
        swichbt = GameObject.Find("Lighting switch");
        swichbuttons = swichbt.GetComponent<SwichButton>();
        battelys = FindObjectOfType<Battelys>();
        //lsets = lightsets.GetComponent<Lightset>();
        globalsm = Globalsc.GetComponent<Global>();

        UseText();
        UseCanvas.SetActive(false);
        count = new int[swichbuttons.Sbutton.Length];//SwichButton��Sbutton�̐����Q��
        for (int i =0; i < count.Length; i++)
        {
            count[i] = 0;
        }
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
    /*
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
    }*/

    

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
                if (swichbuttons != null)
                {
                    for (int j = 0; j < swichbuttons.Sbutton.Length; j++)
                    {
                        //count = 0 Off,count = 1 ON
                        if (count[j] == 0)
                        {
                            count[j] = 1;
                        }
                        else if (count[j] == 1)
                        {
                            count[j] = 0;
                        }

                        if (hit.collider.gameObject == swichbuttons.Sbutton[j])
                        {
                            swichbuttons.SwichGetnum(j);
                        }
                    }
                }
                swichbuttons.Swichjudge();

                if (battelys != null)
                {
                    for (int j = 0; j < battelys.Battely.Length; j++)
                    {
                        if (hit.collider.gameObject == battelys.Battely[j])
                        {
                            battelys.Get_num(j);
                        }
                    }
                }
                if (SceneManager.GetActiveScene().name == "LIghtSampleScene")
                {
                    //buttons = hit.collider.GetComponent<ButtonJudge>();
                    if (buttons != null)
                    {
                        for (int h = 0; h < buttons.button.Length; h++)
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
                        /*for(int j = 0;  j < swichbuttons.Sbutton.Length; j++)
                        {
                            if(hit.collider.gameObject == swichbuttons.Sbutton[j])
                            {
                                swichbuttons.SwichGetnum(j);
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
                        }*/
                    }
                    //Buttonflag();


                    flagjudge();
                   
                }
                if (hit.collider.CompareTag("Goal"))//Goal�^�O�t���Ă���I�u�W�F�N�g��Ray���G�ꂽ����s
                {
                    Debug.Log("Clear!");
                }
            }
            Debug.DrawRay(ray.origin, ray.direction*5, Color.red, 5,false);
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SceneManager.GetActiveScene().name == "LIghtSampleScene")
            {
                //�}�E�X�{�^�����痣�ꂽ���Ɏ��s
                for (int i = 0; i < buttons.flag2.Length; i++)
                {
                    if (buttons.flag2[i] == true)
                    {
                        mremove = true;
                        continue;
                    }
                }
            }
            /*if (buttons.flag2[0] || buttons.flag2[1])
            {
                mremove = true;
                //buttons.flag2[0] = false ;
             }*/
        }

        if (SceneManager.GetActiveScene().name == "LIghtSampleScene")
        {
            if (mremove)
            {
                times = Time.time;
                stimer = times % 10.1f;
                //Debug.Log(stimer);
                if (stimer > 10)
                {
                    mremove = false;
                    checks = false;
                    //false�ɂ��Ď��̎��s�ɔ�����
                    for (int flag = 0; flag < buttons.flag2.Length; flag++)
                    {
                        buttons.flag2[flag] = false;
                    }

                }
            }
        }
        
    }
}
