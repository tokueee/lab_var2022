using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker_Light : MonoBehaviour
{
    public Light targetLight; // 揺らぎを加えるライト
    [SerializeField] GameObject flaLight;
    //private float flickerSpeed; // 揺らぎの速度
    private float intensityMin; // 最小強度
    private float intensityMax; // 最大強度

    //private float time;
    //private float distans;
    [SerializeField] private GameObject player;
    [SerializeField] Player_Light p_light;
    [SerializeField] private GameObject Lenemy;

    // Start is called before the first frame update
    /*
    private float cdists = 10.0f;
    private float mdists = 20.0f;
    private float fcdists = 30.0f;
    private float fdists2 = 40.0f;
    private float noise;
    */
    private float times;
    private float stimer;

    void Start()
    {
        targetLight = GetComponent<Light>();
        p_light = player.GetComponent<Player_Light>();
        //time = 0.0f;
        intensityMax = p_light.Light_main.intensity;
        intensityMin = 0.0f;
        /*cset = Random.Range(0, 2) + 1;
        noise = 2; 
        //Debug.Log(cset);
        */
    }
    private void flash()
    {
        if (p_light.Light_main.intensity <= 90f)
        {
            times = Time.deltaTime;
            stimer = stimer + (times % 2.2f);
            if (stimer <= 1)
            {
                p_light.Light_main.intensity = Random.Range(0, intensityMax);
                p_light.Light_sub.intensity = p_light.Light_main.intensity;
                intensityMax = p_light.Lv_Lm;
            }
            
        }
        else
        {
            stimer = 0.0f;
            //p_light.Light_sub.intensity = p_light.Light_main.intensity;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (targetLight != null)
        {
            flash();

        }
    }
}
