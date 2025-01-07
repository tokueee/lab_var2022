using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titel : MonoBehaviour
{
    public GameObject came;
    [SerializeField] private GameObject controlspanel;
    [SerializeField] private GameObject languagepanel;
    [SerializeField] private Text menu_closes;
    [SerializeField] private Text exits;
    [SerializeField] private Text backt;
    [SerializeField] private Text starttext;
    [SerializeField] private Text languagetext;
    [SerializeField] private Text langbackt;
    [SerializeField] private Text langtext_jp;
    [SerializeField] private Text langtext_en;
    [SerializeField] private GameObject[] button;
    /*
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject C_button;//=2
    [SerializeField] private GameObject exitbutton;
    [SerializeField] private GameObject backbutton;*/

    private float dtimes;
    private float stimers;

    private bool deley;

    private string menuclosetexts;
    private string exittext;
    private string backbuttontext;
    private string startbuttontext;
    private string langagebuttontext;
    private string langjtext;
    private string langtexts_en;

    Controls_text controls_;
    public enum Language
    {
        Eng,
        Jpn
    }
    public Language language;
    void Menu_closes()
    {
        if (language == Language.Eng)
        {
            menuclosetexts = "MenuClose and Start";
        }
        else
        {
            menuclosetexts = "閉じて始める";
        }
        menu_closes.text = menuclosetexts;
        menu_closes.fontSize = 45;
    }

    void exitT()
    {
        if(language == Language.Eng)
        {
            exittext = "End";
        }
        else
        {
            exittext = "終了";
        }
        exits.text = exittext;
    }

    void backText()
    {
        if (language == Language.Eng)
        {
            backbuttontext = "Back";
        }
        else
        {
            backbuttontext = "戻る";
        }
        backt.text = backbuttontext;
        backt.fontSize = 27;
    }

    void Start_T()
    {
        if (language == Language.Eng)
        {
            startbuttontext = "START";
        }
        else
        {
            startbuttontext = "始める";
        }
        starttext.text = startbuttontext;
    }

    void langT()
    {
        if (language == Language.Eng)
        {
            langagebuttontext = "Language";
        }
        else
        {
            langagebuttontext = "言語";
        }
        languagetext.text = langagebuttontext;
    }

    void langbT()
    {
        langbackt.text = backbuttontext;
        langbackt.fontSize = 21;
    }
    void Langchange()
    {
        switch (language)
        {
            case Language.Eng:
                langjtext = "Japanese";
                langtexts_en = "English";
                TitleTextSet();
                break;
            case Language.Jpn:
                langjtext = "日本語";
                langtexts_en = "英語";
                TitleTextSet();
                break;
        }
        langtext_jp.text = langjtext;
        langtext_en.text = langtexts_en;
    }
    void TitleTextSet()
    {
        Menu_closes();
        exitT();
        backText();
        Start_T();
        langT();
        langbT();
    }

    // Start is called before the first frame update
    void Start()
    {
        Langchange();
        TitleTextSet();
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        //cntrol + Pでプレイ
        controlspanel.SetActive(false);
        languagepanel.SetActive(false);
        controls_ = GetComponent<Controls_text>();
        Debug.Log("Current Scene: " + SceneManager.GetActiveScene().name);
    }

    public void JpnClick()
    {
        if(language == Language.Eng)
        {
            language = Language.Jpn;
        }
        Langchange();
    }
    public void EngClick()
    {
        if (language == Language.Jpn)
        {
            language = Language.Eng;
        }
        Langchange();
    }

    public void Onclicks()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    public void Close_click()
    {
        deley = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (deley)
        {
            dtimes = Time.deltaTime;
            stimers = stimers + (dtimes % 2.2f);
            Debug.Log(stimers);
            if (stimers > 2)
            {
                deley = false;
                SceneManager.LoadScene("LightSampleScene");
                //deley = false;
            }
        }
    }
}
