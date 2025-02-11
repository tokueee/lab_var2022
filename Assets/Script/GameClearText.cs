using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    public Text clearText; // Inspector で設定
    public string fullText = "僕は友達を見送った\n君ともっと遊んでいかったな\n僕はここから出られないけど\nまた遊びに来てね...\nEND"; // 表示するテキスト
    public Text btext;
    public string buttanText = "<ボタンを押してタイトルに戻る>"; // 表示するテキスト
    public float delay = 0.1f; // 文字が表示される間隔
    public float activedelay = 0.3f;
    [SerializeField] private GameObject Titelbuttan;

    void Start()
    {
        clearText.text = ""; // 最初は空の状態
        StartCoroutine(ShowText());

    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            clearText.text += fullText[i]; // 1文字ずつ追加
            if (fullText[i] != '\n')//出力文字が改行を表す「\n」の時はその次の文字まで待つことはしない。
            {
                yield return new WaitForSeconds(delay);
            }// 次の文字を表示するまで待つ
        }
        yield return new WaitForSeconds(activedelay);
        Titelbuttan.SetActive(true);
        for (int i = 0; i < buttanText.Length; i++)
        {
            btext.text += buttanText[i]; // 1文字ずつ追加
            if (buttanText[i] != '\n')//出力文字が改行を表す「\n」の時はその次の文字まで待つことはしない。
            {
                yield return new WaitForSeconds(delay);
            }// 次の文字を表示するまで待つ
        }
    }
}