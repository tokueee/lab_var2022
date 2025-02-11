using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clear_text : MonoBehaviour
{

    [SerializeField] private GameObject Cava_Clear;
    [SerializeField] private GameObject Cava_notask;
    [SerializeField] private MouseAction MauseA;//MauseAction
    [SerializeField] private Text pane_tit;//panel_titel
    [SerializeField] private Text text;
    [SerializeField] private Text name;
    [SerializeField] private Text serif;

    [SerializeField] private Boy boy;


    [SerializeField]private Pause pause;
    [System.NonSerialized]public bool touch_Goal=false;
    private float time;

    private string nowtext;

    void Start()
    {
        pause = FindObjectOfType<Pause>();
        Cava_Clear.SetActive(false);
        Cava_notask.SetActive(false);
        SetLanguage();
    }

    // Update is called once per frame
    void Update()
    {
        if (touch_Goal)//goal�^�O�̒������I�u�W�F�N�g���N���b�N�����Ƃ�
        {
            if (boy.isPlayer)//boy�ƈꏏ�ɂ��邩
            {
                pause.check_clear = false;
                pause.PauseOn();
                Cava_Clear.SetActive(true);
                if (Input.anyKeyDown) { Next(); Debug.Log("AnyKey"); }
            }
            else
            {
                Cava_notask.SetActive(true);
                time = time + Time.deltaTime;
                //Debug.Log(time);
                if (time > 5)
                {
                    touch_Goal = false;
                    Cava_notask.SetActive(false);
                    time = 0;
                }
            }
        }
    }


    public void Next()
    {
        UI_SetActive.EndGame();
        pause.PauseOff();
        pause.check_clear = true;
    }

    //�ȉ��֐�_����֌W
    private void Panel_Title()
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "Game Clear";
        }
        else
        {
            nowtext = "�N���A";
        }
        pane_tit.text = nowtext;
    }
    private void Text_advice()
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "\"Press any key to return to title.\"";
        }
        else
        {
            nowtext = "\"�C�ӂ�Key�������ă^�C�g��\"";
        }
        text.text = nowtext;
    }
    private void Name_my()
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "I";
        }
        else
        {
            nowtext = "��";
        }
        name.text = nowtext;
    }
    private void selif_Goal_notask()
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "I can't leave him behind.\nI need to find him soon.";
        }
        else
        {
            nowtext = "�ނ�u���Ă����킯�ɂ͍s���Ȃ��B\n���������Ȃ���...";
        }
        serif.text = nowtext;
    }

    public void SetLanguage()
    {
        Panel_Title();
        Text_advice();
        Name_my();
        selif_Goal_notask();
    }
}
