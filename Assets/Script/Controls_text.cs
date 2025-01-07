using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls_text : MonoBehaviour
{
    [SerializeField] private GameObject panel;//�p�l������p
    [SerializeField] private GameObject otext;//���������������邽�߂̕ϐ�
    [SerializeField] private GameObject gamesystem;

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

    Titel titel;
    // Start is called before the first frame update

    void heading()
    {
        /*if(titel.language == Titel.Language.Eng)
        {
            headcontrol = "PLAYER CONTROLS";
        }
        else
        {
            headcontrol = "������@";
        }*/
        headcontrol = "PLAYER CONTROLS";
        pcontrol.text = headcontrol;
        pcontrol.fontSize = 50;
    }

    void Moving()
    {
        /*if (titel.language == Titel.Language.Eng)
        {
            movecontrol = "MOVE\nW Key Front\tA Key Left\nS  key Back \tD Key Right\nMoveKey + SHIFT Dash";
        }
        else
        {
            movecontrol = "����\nW Key �O\tA key �� \nS Key ��� \tD key �E\n�ړ��L�[ + SHIFT �_�b�V��";
        }*/
        movecontrol = "MOVE\nW Key Front\tA Key Left\nS  key Back \tD Key Right\nMoveKey + SHIFT Dash";
        mcontrol.text = movecontrol;
        mcontrol.fontSize = 40;
    }
    void lighting()
    {
        lightcontrol = "LIGHT\nF Key    Light ON/OFF";
        light_s.text = lightcontrol;
        light_s.fontSize = 40;
    }
    void MouseControler()
    {
        mousecontrol = "MOUSE\nMoveMouse   CameraControl\nLeftClick   Use";
        mouse_c.text = mousecontrol;
        mouse_c.fontSize = 40;
    }
    void Menu_Opens()
    {
        menutext = "E Key MenuOpen";
        menu_open.text = menutext;
        menu_open.fontSize = 35;
    }
    void Menu_close()
    {
        menuclosetext = "E Key MenuClose";
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
        titel = gamesystem.GetComponent<Titel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf == false)
        {
            panel.SetActive(true);
            otext.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf)
        {
            panel.SetActive(false);
            otext.SetActive(true);
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }*/
    }
}
