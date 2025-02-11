using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    public Text clearText; // Inspector �Őݒ�
    public string fullText = "�l�͗F�B����������\n�N�Ƃ����ƗV��ł���������\n�l�͂�������o���Ȃ�����\n�܂��V�тɗ��Ă�...\nEND"; // �\������e�L�X�g
    public Text btext;
    public string buttanText = "<�{�^���������ă^�C�g���ɖ߂�>"; // �\������e�L�X�g
    public float delay = 0.1f; // �������\�������Ԋu
    public float activedelay = 0.3f;
    [SerializeField] private GameObject Titelbuttan;

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
            if (fullText[i] != '\n')//�o�͕��������s��\���u\n�v�̎��͂��̎��̕����܂ő҂��Ƃ͂��Ȃ��B
            {
                yield return new WaitForSeconds(delay);
            }// ���̕�����\������܂ő҂�
        }
        yield return new WaitForSeconds(activedelay);
        Titelbuttan.SetActive(true);
        for (int i = 0; i < buttanText.Length; i++)
        {
            btext.text += buttanText[i]; // 1�������ǉ�
            if (buttanText[i] != '\n')//�o�͕��������s��\���u\n�v�̎��͂��̎��̕����܂ő҂��Ƃ͂��Ȃ��B
            {
                yield return new WaitForSeconds(delay);
            }// ���̕�����\������܂ő҂�
        }
    }
}