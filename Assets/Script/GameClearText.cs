using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    public Text clearText; // Inspector で設定
    public string fullText = "END\nリンゴ"; // 表示するテキスト
    public float delay = 0.1f; // 文字が表示される間隔

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
            if (fullText[i] != '\n')
            {
                yield return new WaitForSeconds(delay);
            }// 次の文字を表示するまで待つ
        }
    }
}