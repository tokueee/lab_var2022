using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver_Text : MonoBehaviour
{
    //GameOverScene
    //Loadするシーンの名前設定
    private string retry = "MainGame";
    private string title = "TitelScene";

    [SerializeField] private Text GameoverText;
    [SerializeField] private Text Retrybutton;
    [SerializeField] private Text Titlebutton;

    private string Gameovertexts;
    private string retrytext;
    private string titletext;

    private Global globals;
    public void retryClick()
    {
        SceneManager.LoadScene(retry);
    }

    public void TitleClick()
    {
        SceneManager.LoadScene(title);
    }

    void GameOverT()
    {
        if(globals.GetLanguage() == Global.Language.Eng)
        {
            Gameovertexts = "GAME OVER";
        }
        else
        {
            Gameovertexts = "ゲームオーバー";
        }
        //Gameovertexts = "GAME OVER";
        GameoverText.text = Gameovertexts;
        GameoverText.fontSize = 90;
    }

    void RetryT()
    {
        if(globals.GetLanguage() == Global.Language.Eng)
        {
            retrytext = "RETRY";
        }
        else
        {
            retrytext = "リトライする";
        }
        //retrytext = "RETRY";
        Retrybutton.text = retrytext;
        Retrybutton.fontSize = 40;
    }

    void TitleT()
    {
        if (globals.GetLanguage() == Global.Language.Eng)
        {
            titletext = "TITLE";
        }
        else
        {
            titletext = "タイトルヘ";
        }
        //titletext = "TITLE";
        Titlebutton.text = titletext;
        Titlebutton.fontSize = 40;
    }
    public void GameOverSet()
    {
        GameOverT();
        RetryT();
        TitleT();
    }
    // Start is called before the first frame update
    void Start()
    {
        globals = FindObjectOfType<Global>();
        GameOverSet();
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        //globals = GetComponent<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
