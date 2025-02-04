using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    public Text clearText; // Inspector �Őݒ�
    public string fullText = "END\n�����S"; // �\������e�L�X�g
    public float delay = 0.1f; // �������\�������Ԋu

    void Start()
    {
        clearText.text = ""; // �ŏ��͋�̏��
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            clearText.text += fullText[i]; // 1�������ǉ�
            if (fullText[i] != '\n')
            {
                yield return new WaitForSeconds(delay);
            }// ���̕�����\������܂ő҂�
        }
    }
}