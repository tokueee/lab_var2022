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

    public enum language
    {
        Eng,
        Jpn
    }
    void Menu_closes()
    {
        menuclosetexts = "MenuClose";
        menu_closes.text = menuclosetexts;
        menu_closes.fontSize = 45;
    }

    void exitT()
    {
        exittext = "End";
        exits.text = exittext;
    }

    void backText()
    {
        backbuttontext = "Back";
        backt.text = backbuttontext;
        backt.fontSize = 27;
    }

    void Start_T()
    {
        startbuttontext = "START";
        starttext.text = startbuttontext;
    }

    void langT()
    {
        langagebuttontext = "Language";
        languagetext.text = langagebuttontext;
    }
    void TextSet()
    {
        Menu_closes();
        exitT();
        backText();
        Start_T();
        langT();
    }

    // Start is called before the first frame update
    void Start()
    {
        TextSet();
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        //cntrol + P‚ÅƒvƒŒƒC
        controlspanel.SetActive(false);
        languagepanel.SetActive(false);
        Debug.Log("Current Scene: " + SceneManager.GetActiveScene().name);
    }

    /*public void Click()
    {
        if (canvaspanel.activeSelf == false)
        {
            canvaspanel.SetActive(true);
            button.SetActive(false);
            exitbutton.SetActive(false);
        }
    }*/

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
        if (controlspanel.activeSelf)
        {
            deley = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Space) && canvaspanel.activeSelf == false)
        {
            canvaspanel.SetActive(true);
        }
        if (canvaspanel.activeSelf)
        {
            deley = true;
            //canvaspanel.SetActive(false);
        }*/

        if (deley)
        {
            dtimes = Time.deltaTime;
            stimers = stimers + (dtimes % 4.2f);
            Debug.Log(stimers);
            if (stimers > 4)
            {
                //deley = false;
                controlspanel.SetActive(false);
                button[2].SetActive(false);
                if (stimers > 5)
                {
                    deley = false;
                    SceneManager.LoadScene("LightSampleScene");
                }
                //SceneManager.LoadScene("LightSampleScene");
                /*if (Input.GetKeyDown(KeyCode.Space) && canvaspanel.activeSelf)
                {
                    deley = true;
                    //canvaspanel.SetActive(false);
                }

                if (deley)
                {
                    times = Time.deltaTime;
                    stimer = stimer + (times % 4.2f);
                    Debug.Log(stimer);
                    if(stimer > 4)
                    {
                        //deley = false;
                        canvaspanel.SetActive(false);
                        if(stimer > 5)
                        {
                            deley = false;
                            SceneManager.LoadScene("LightSampleScene");
                        }
                        //SceneManager.LoadScene("LightSampleScene");
                    }
                }*/
            }
        }
    }
}
