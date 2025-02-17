using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;


public class Lightset : MonoBehaviour
{ 
    //private float minlight = 0.0f;
    //private float maxlight = 3.7f;

    private float timer = 60.0f;
    //private float times;
    //private float timer2;
    //private float[] stime = new float[5];
    //private float[] slight = new float[5];
    private int num;
    private int maxnum;
    private bool nf = false;
    private bool[] on = new bool[5];
    //private int p = 7;
    //private float[] ftime;

    public float starttime;
    public float dtime;
    public float keyDtime;
    [SerializeField] private GameObject buttons;
    [SerializeField] private GameObject playcs;
    [SerializeField] private MouseAction mouseaction;
    [SerializeField] private Player player;
    public bool oneclick = false;
    //public GameObject noi;
    //public Light flight;
    [SerializeField]
    private GameObject[] light;

    //public Light[] mylight;

    //int i = 0;
    int lightoffCount = 1;
    int count =0;

    Randam ran;
    ButtonJudge button;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject player = GameObject.Find("Player");//名前変更に注意

        mouseaction = buttons.GetComponent<MouseAction>();
        player = playcs.GetComponent<Player>();

        ran = buttons.GetComponent<Randam>();
        button = buttons.GetComponent<ButtonJudge>();
    }

    IEnumerator LightOff()
    {
        yield return new WaitForSeconds(starttime);
        light[0].SetActive(false);
        yield return new WaitForSeconds(dtime);
        light[1].SetActive(false);
        light[2].SetActive(false);
        yield return new WaitForSeconds(dtime);
        for(int j = 0;j < light.Length;j++)
        {
            if (light[j].activeSelf == true)
            {
                if (light[j] == light[6])
                {
                    light[6].SetActive(false);
                    light[7].SetActive(false);
                    light[16].SetActive(false);
                    yield return new WaitForSeconds(dtime);
                }else if (light[j] == light[8])
                {
                    light[8].SetActive(false);
                    light[9].SetActive(false);
                    light[17].SetActive(false);
                    yield return new WaitForSeconds(dtime);
                }
                if (light[j] == light[10])
                {
                    light[10].SetActive(false);
                    light[12].SetActive(false);
                    light[18].SetActive(false);
                    yield return new WaitForSeconds(dtime);
                }
                if (light[j] == light[11])
                {
                    light[11].SetActive(false);
                    light[13].SetActive(false);
                    light[19].SetActive(false);
                    yield return new WaitForSeconds(dtime);
                }
                if (light[15].activeSelf == false)
                {
                    yield return new WaitForSeconds(dtime);
                }
                    light[j].SetActive(false);
                yield return new WaitForSeconds(dtime);
            }
        }
    }
    void changelight(int n)
    {
        //Debug.Log(n);
        if (ran.spone)
        {
            button.enemyLSpot[n].color = Color.red;
            button.enemyLSpotP[n].color = Color.red;
        }
        else if(!ran.spone)
        {
            button.enemyLSpot[n].color = Color.white;
            button.enemyLSpotP[n].color = Color.white;
        }
    }

    IEnumerator Keyboard_LightOn()
    {
        if (mouseaction.Buttonj1() == true)
        {
            //Debug.Log(ran.spone);
            changelight(0);
            /*if (ran.spone)
            {
                button.enemyLSpot[0].color = Color.red;
                button.enemyLSpotP[0].color = Color.red;
            }
            else
            {
                button.enemyLSpot[0].color = Color.white;
                button.enemyLSpotP[0].color = Color.white;
            }*/
            if (light[2].activeSelf == false)
            {
                //light[2]が消えているなら実行
                //oneclick = false;
                num = 0;
                maxnum = 2;
                on[0] = true;
                light[0].SetActive(true);
                light[1].SetActive(true);
                light[2].SetActive(true);
                yield return new WaitForSeconds(keyDtime);
                StartCoroutine(Keyboad_LightOff());
            }
            else if (light[2].activeSelf == true)
            {
                oneclick = false;
            }
            //Debug.Log(playerscript.flag);
        }
        if (mouseaction.Buttonj2() == true)
        {
            if (light[18].activeSelf == false)
            {
                changelight(1);
                //Debug.Log("ON");
                //light[18]が消えているなら実行
                //oneclick = false;
                num = 16;
                maxnum = 18;
                nf = true;
                on[1] = true;
                light[4].SetActive(true);
                light[16].SetActive(true);
                light[17].SetActive(true);
                light[18].SetActive(true);
                yield return new WaitForSeconds(keyDtime);
                StartCoroutine(Keyboad_LightOff());
            }
            else if (light[18].activeSelf == true)
            {
                oneclick = false;
            }

            /*yield return new WaitForSeconds(keyDtime);
            StartCoroutine(Keyboad_LightOff());*/
        }
        if (mouseaction.Buttonj3() == true)
        {
            if (light[7].activeSelf == false)
            {
                changelight(2);
                //light[7]が消えているなら実行
                //oneclick = false;
                num = 5;
                maxnum = 7;
                on[2] = true;
                light[5].SetActive(true);
                light[6].SetActive(true);
                light[7].SetActive(true);
                yield return new WaitForSeconds(keyDtime);
                StartCoroutine(Keyboad_LightOff());
            }
            else if (light[7].activeSelf == true)
            {
                oneclick = false;
            }

        }
        if (mouseaction.Buttonj4() == true)
        {
            if (light[15].activeSelf == false)
            {
                changelight(3);
                //light[15]が消えているなら実行
                //oneclick = false;
                num = 12;
                maxnum = 15;
                on[3] = true;
                light[12].SetActive(true);
                light[13].SetActive(true);
                light[14].SetActive(true);
                light[15].SetActive(true);
                yield return new WaitForSeconds(keyDtime);
                StartCoroutine(Keyboad_LightOff());
            }
            else if (light[15].activeSelf == true)
            {
                oneclick = false;
            }
        }
        if (mouseaction.Buttonj5() == true)
        {
            if (light[11].activeSelf == false)
            {
                changelight(4);
                //light[11]が消えているなら実行
                //oneclick = false;
                num = 8;
                maxnum = 11;
                on[4] = true;
                light[8].SetActive(true);
                light[9].SetActive(true);
                light[10].SetActive(true);
                light[11].SetActive(true);
                yield return new WaitForSeconds(keyDtime);
                StartCoroutine(Keyboad_LightOff());
            }
            else if (light[11].activeSelf == true)
            {
                oneclick = false;
            }
        }

        //Debug.Log(mylight[0]);
    }

    void buttonchecks()
    {
        for(int i = 0; i < on.Length; i++)
        {
            on[i] = false;
        }
        //Debug.Log(on);
        if (ran.spone) { ran.spone = false; }
    }

    IEnumerator Keyboad_LightOff()
    {
        if(nf == true)
        {
            //light[4]だけ他ライトと値が離れているのでここで消す
            light[4].SetActive(false);
            nf = false;
            yield return new WaitForSeconds(keyDtime);
        }
        
        //if (ran.spone){ ran.spone = false;}
        //ボタン色変え(保留)
       /* for(int j=0; j < on.Length; j++) {
            if (on[j] == true)
            {
                button.buttonColor(j);
            }
        }*/

        for (int k = num; k <= maxnum; k++)
        {
            light[k].SetActive(false);
            //Debug.Log(k);
            
            //2,18,7,15,11
            if (light[k] == light[2] && light[2].activeSelf == false) { buttonchecks(); }
            if (light[k] == light[18] && light[18].activeSelf == false) { buttonchecks(); }
            if (light[k] == light[7] && light[7].activeSelf == false) { buttonchecks(); }
            if (light[k] == light[15] && light[15].activeSelf == false) { buttonchecks(); }
            if (light[k] == light[11] && light[11].activeSelf == false) { buttonchecks(); }
            yield return new WaitForSeconds(keyDtime);

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("Mouse X"));
        //StartCoroutine(lighting());
        if(player.StartPlane() == true)
        {
            if (lightoffCount > count)
            {
                if (light[light.Length - 1].activeSelf == true)
                {
                    //Debug.Log("OK");
                    StartCoroutine(LightOff());
                    count++;
                }
            }
            if (mouseaction.flagjudge() == true) { StartCoroutine(Keyboard_LightOn()); }
        }
        /*if(lightoffCount > count)
        {
            if (light[light.Length - 1].activeSelf == true)
            {
                Debug.Log("OK");
                StartCoroutine(LightOff());
                count++;
            }
        }
        if(mouseaction.flagjudge() == true) { StartCoroutine(Keyboard_LightOn()); }
        */

    }
}
