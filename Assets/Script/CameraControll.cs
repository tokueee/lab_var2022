using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class CameraControll: MonoBehaviour
{
    //�Ǐ]���ė~�����I�u�W�F�N�g
   
    public Transform target;
    public Vector3 offset;//inspector�́uY�v�Ɂu0.7�v������
    public Transform camera;
    public Transform Light;
    private Vector3 campos;
    private float RotateSpeed = 1.5f;

    public Vector3 Rot_Camera = Vector3.zero;

    [SerializeField] private GameObject player;//������������Player������
    [SerializeField] private Player playerc;

    private float sin;


    public float freque = 10;
    public float dfreque = 100;
    private float time;
    public float speed = 2f;
    public float dspeed = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        playerc =player.GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 campos = camera.position;
        campos = target.position + offset;
        //�J�������Z�b�g
        if (Input.GetKey(KeyCode.R))
        {
            Rot_Camera = Vector3.zero;
        }

        //transform.position = target.position + offset;

        Rot_Camera.x -= Input.GetAxis("Mouse Y") * RotateSpeed;
        Rot_Camera.x = Mathf.Clamp(Rot_Camera.x, -90, 90);
        Rot_Camera.y += Input.GetAxis("Mouse X") * RotateSpeed;

        transform.rotation = Quaternion.Euler(0, Rot_Camera.y, 0);
        camera.rotation = Quaternion.Euler(Rot_Camera.x, Rot_Camera.y, 0);
        Light.rotation = Quaternion.Euler(Rot_Camera.x, Rot_Camera.y, 0);

        if (playerc.spu && playerc.pu)
        {
            time += Time.deltaTime;
            sin = Mathf.Sin(180 * time * dspeed * Mathf.Deg2Rad);
            campos.y += sin / dfreque;
            //Debug.Log("sin = " + sin);
        }
        else if (playerc.pu)
        {
            time += Time.deltaTime;
            sin = Mathf.Sin(180 * time* speed * Mathf.Deg2Rad);
            campos.y += sin / freque;
        }

        transform.position = campos;
        /*sin = Mathf.Sin(Time.time);
        campos.y = campos.y + sin;*/
        
        //Debug.Log("sin = " + sin);
        //Debug.Log(campos.y);
    }
}
