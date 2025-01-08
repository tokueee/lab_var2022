using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controls_text : MonoBehaviour
{
    [SerializeField] private GameObject panel;//�p�l������p
    [SerializeField] private GameObject otext;//���������������邽�߂̕ϐ�
    [SerializeField] private GameObject ctext;
    //[SerializeField] private GameObject gamesystem;

    //�e�L�X�g�擾
    [SerializeField] private Text pcontrol;
    [SerializeField] private Text mcontrol;
    [SerializeField] private Text light_s;
    [SerializeField] private Text mouse_c;
    [SerializeField] private Text menu_open;
    [SerializeField] private Text menu_close;

    //�e�L�X�g�ύX�p�ϐ�
    private string headcontrol;
    private string movecontrol;
    private string lightcontrol;
    private string mousecontrol;
    private string menutext;
    private string menuclosetext;

    [SerializeField] private Global globalcontrol;
    // Start is called before the first frame update

    void heading()
    {
        if(globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            headcontrol = "PLAYER CONTROLS";
        }
        else
        {
            headcontrol = "������@";
        }
        //headcontrol = "PLAYER CONTROLS";
        pcontrol.text = headcontrol;
        pcontrol.fontSize = 50;
    }

    void Moving()
    {
        if (globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            movecontrol = "MOVE\nW Key Front\tA Key Left\nS  key Back \tD Key Right\nMoveKey + SHIFT Dash";
        }
        else
        {
            movecontrol = "����\nW Key �O\tA key �� \nS Key ��� \tD key �E\n�ړ��L�[ + SHIFT �_�b�V��";
        }
        //movecontrol = "MOVE\nW Key Front\tA Key Left\nS  key Back \tD Key Right\nMoveKey + SHIFT Dash";
        mcontrol.text = movecontrol;
        mcontrol.fontSize = 40;
    }
    void lighting()
    {
        if (globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            lightcontrol = "LIGHT\nF Key    Light ON/OFF";
        }
        else
        {
            lightcontrol = "���C�g\nF Key    ���C�g ON/OFF";
        }
        //lightcontrol = "LIGHT\nF Key    Light ON/OFF";
        light_s.text = lightcontrol;
        light_s.fontSize = 40;
    }
    void MouseControler()
    {
        if (globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            mousecontrol = "MOUSE\nMoveMouse   CameraControl\nLeftClick   Use";
        }
        else
        {
            mousecontrol = "�}�E�X����\n�}�E�X�ړ�   �J�������_����\n���N���b�N   �g�p";
        }
        //mousecontrol = "MOUSE\nMoveMouse   CameraControl\nLeftClick   Use";
        mouse_c.text = mousecontrol;
        mouse_c.fontSize = 40;
    }
    void Menu_Opens()
    {
        if (globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            menutext = "E Key MenuOpen";
        }
        else
        {
            menutext = "E Key ���j���[���J��";
        }
        //menutext = "E Key MenuOpen";
        menu_open.text = menutext;
        menu_open.fontSize = 35;
    }
    void Menu_close()
    {
        if (globalcontrol.GetLanguage() == Global.Language.Eng)
        {
            menuclosetext = "E Key MenuClose";
        }
        else
        {
            menuclosetext = "E Key ���j���[�����";
        }
        //menuclosetext = "E Key MenuClose";
        menu_close.text = menuclosetext;
        menu_close.fontSize = 45;
    }
    public void TextSet()
    {
        heading();
        Moving();
        lighting();
        MouseControler();
    }

    void Start()
    {
        panel.SetActive(false);
        TextSet();//�����ݒ�
        Menu_close();
        Menu_Opens();
        globalcontrol = GetComponent<Global>();
        Debug.Log(globalcontrol.GetLanguage());

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "LIghtSampleScene")
        {
            if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf == false)
            {
                panel.SetActive(true);
                //ctext.SetActive(true);
                otext.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf)
            {
                panel.SetActive(false);
                //ctext.SetActive(false);
                otext.SetActive(true);
            }
        }
        /*if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf == false)
        {
            panel.SetActive(true);
            otext.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf)
        {
            panel.SetActive(false);
            otext.SetActive(true);
        }*/
    }
        
}
