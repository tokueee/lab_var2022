using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_SetActive : MonoBehaviour
{
    [SerializeField] private GameObject PauseCanvas;
    [SerializeField] private GameObject OptionCanvas;
    [SerializeField] private Pause poseScript; // pose�X�N���v�g�̎Q��

    [SerializeField] private GameObject menucanvas;

    //�ȉ���`_����ݒ�p
    //private Global Setting_global;
    [SerializeField] private Text canv_tit;//canvase_title
    //���I�����̐����������p�ӂ��A�e�L�X�g���A�T�C������ϐ�
    [SerializeField] private Text[] select;
    private string nowtext;

    // Start is called before the first frame update
    void Start()
    {
        length_cheng();
        PauseCanvas.SetActive(false);
        OptionCanvas.SetActive(false);
        //Setting_global = FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        if (poseScript.IsPaused())
        {
            if (OptionCanvas && OptionCanvas.activeSelf)
            {
                PauseCanvas.SetActive(false);
            }
            else
            {
                PauseCanvas.SetActive(true);
                menucanvas.SetActive(false);
            }
        }
        else
        {
            PauseCanvas.SetActive(false);
            menucanvas.SetActive(true);
        }

    }
    public void PCamvas_Active()//�|�[�Y
    {
        PauseCanvas.SetActive(false);
    }

    public void OCamvas_Active()//�I�v�V����
    {
        OptionCanvas.SetActive(false);
    }


    public static void EndGame()
    {
        SceneManager.LoadScene("TitelScene");
    }


    //�ȉ��֐�_����ݒ�p
    private void Title_Pause()
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "PAUSE";
        }
        else
        {
            nowtext = "�|�[�Y";
        }
        canv_tit.text = nowtext;
    }
    private void Option_In_Pause()//option
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "OPTION";
        }
        else
        {
            nowtext = "�ݒ�";
        }
        select[0].text = nowtext;
    }
    private void Exit_to_title()//exit to title
    {
        if (Global.language == Global.Language.Eng)
        {
            nowtext = "EXIT TO TITLE";
        }
        else
        {
            nowtext = "�^�C�g��";
        }
        select[1].text = nowtext;
    }

    private void length_cheng()
    {
        Title_Pause();
        Option_In_Pause();
        Exit_to_title();
    }
}
