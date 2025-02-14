using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Rigidbody rb;
    private GameObject O_C;
    CameraControll CameraCS;
    Player_Light Player_Light;
    Vector3 get_see;

    [System.NonSerialized]//public変数をインスペクター上に表示したくない時に使えるやつ
    public int keyCount;
    [System.NonSerialized]
    public bool key_W, key_A, key_S, key_D,key_F, key_Shift;
    float[] global_x = new float[4], global_y = new float[4], global_z = new float[4];//移動制御変数
    Vector3 global;

    float mspeed;//速度変数
    public float Speed_Walking, Speed_Running;//歩く速度と走る速度
    //※int SaveSpeed = 5;//速度制御用変数


    /*public bool flag = false;
    public bool flag2 = false;*/
    public bool[] flags;
    //flags[0] はbuttonの判定
    //public GameObject[] Button;
    
    [SerializeField] private GameObject s_object;
    private bool sta;


    public bool pu = false;
    public bool spu = false;
    private Collider Collide;
    private int platecount = 0;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //player_light = Light.GetComponent<Light>();
        //UpdateLight();
        O_C = GameObject.Find("Main Camera");
        CameraCS = O_C.GetComponent<CameraControll>();

        Player_Light = GetComponent<Player_Light>();
        //Collide = s_object.GetComponent<Collider>();

        key_F = false;
        key_Shift = true;
    }

    public bool StartPlane()
    {
        return sta;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == s_object)
        {
            platecount++;
            if (platecount >= 2)
            {
                Collide.isTrigger = false;
            }
            sta = true;
            StartPlane();
            //Debug.Log(platecount);
        }
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        get_see = CameraCS.Rot_Camera;
        //各速度の値を毎度初期化
        keyCount = 0;
        key_W = false; key_A = false; key_S = false; key_D = false; 
        for (int i = 0; i < 4; i++)
        {
            global_x[i] = 0; global_y[i] = 0; global_z[i] = 0;
        }


        //移動
        {
            //前に進む
            if (Input.GetKey(KeyCode.W))
            {
                keyCount += 1;
                key_W = true;
            }
            //後に進む
            if (Input.GetKey(KeyCode.S))
            {
                keyCount += 1;
                key_S = true;
            }
            //右に進む
            if (Input.GetKey(KeyCode.D))
            {
                keyCount += 1;
                key_D = true;
            }
                //左に進む
                if (Input.GetKey(KeyCode.A))
            {
                keyCount += 1;
                key_A = true;
            }
        }

        //左Shiftキーを検知する
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //SaveSpeed = 5;
                key_Shift = true;
            }
            else
            {
                //SaveSpeed = 3;
                key_Shift = false;
            }

            if (keyCount >= 2)
            {
                mspeed = mspeed / Mathf.Sqrt(2);

            }
        }
    }

    private void Update() 
    {

        //Shiftキーでダッシュする
        {
            if (key_Shift)
            {
                //SaveSpeed = 5;
                mspeed = Speed_Running;
            }
            else
            {
                //SaveSpeed = 3;
                mspeed = Speed_Walking;
            }

            if (keyCount >= 2)
            {
                mspeed = mspeed / Mathf.Sqrt(2);
                //Debug.Log(Mathf.Sqrt(2));

            }
        }
        //WASD keyのどれかが押されたときの反応(移動)
        {


            if (key_W)
            {
                //rb.AddForce(transform.forward * mspeed);
                global_z[0] = mspeed * Mathf.Cos(get_see.y / 180 * Mathf.PI);
                global_x[0] = mspeed * Mathf.Sin(get_see.y / 180 * Mathf.PI);
            }
            //後に進む
            if (key_S)
            {
                //rb.AddForce(-transform.forward * mspeed);
                global_z[2] = -mspeed * Mathf.Cos(get_see.y / 180 * Mathf.PI);
                global_x[2] = -mspeed * Mathf.Sin(get_see.y / 180 * Mathf.PI);
            }
            //右に進む
            if (key_D)
            {
                //rb.AddForce(transform.right * mspeed);
                global_z[3] = mspeed * Mathf.Cos((get_see.y + 90) / 180 * Mathf.PI);
                global_x[3] = mspeed * Mathf.Sin((get_see.y + 90) / 180 * Mathf.PI);
            }
            //左に進む
            if (key_A)
            {
                //rb.AddForce(-transform.right * mspeed);
                global_z[1] = -mspeed * Mathf.Cos((get_see.y + 90) / 180 * Mathf.PI);
                global_x[1] = -mspeed * Mathf.Sin((get_see.y + 90) / 180 * Mathf.PI);
            }

            global.x = global_x[0] + global_x[1] + global_x[2] + global_x[3];
            global.z = global_z[0] + global_z[1] + global_z[2] + global_z[3];
            global.y = rb.velocity.y;

            rb.velocity = global;

            //Debug.Log(rb.velocity);
        }

        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Player_Light.ChageLight();
            }
        }
    }

}
