using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver_Text : MonoBehaviour
{
    //GameOverScene
    //LoadÇ∑ÇÈÉVÅ[ÉìÇÃñºëOê›íË
    private string retry = "LightSampleScene";
    private string title = "TitelScene";

    [SerializeField] private Text GameoverText;
    [SerializeField] private Text Retrybutton;
    [SerializeField] private Text Titlebutton;

    private string Gameovertexts;
    private string retrytext;
    private string titletext;

    Global globals;
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
        Gameovertexts = "GAME OVER";
        GameoverText.text = Gameovertexts;
        GameoverText.fontSize = 90;
    }

    void RetryT()
    {
        retrytext = "RETRY";
        Retrybutton.text = retrytext;
        Retrybutton.fontSize = 40;
    }

    void TitleT()
    {
        titletext = "TITLE";
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
        GameOverSet();
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        globals = GetComponent<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
