using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeController : MonoBehaviour
{
    public Image fadeImage;
    public float fadeTime;
    private static GameObject mainCanvasInstance;
    private bool isTransitioning = false;
    public GameObject[] mainUI;
    public GameObject[] GameOverObject;

    void Awake()
    {
        // Main�V�[����Canvas�̂�DontDestroyOnLoad�ɂ���
        if (mainCanvasInstance == null)
        //SceneManager.GetActiveScene().name == "TScene" && mainCanvasInstance == null)
        {
            DontDestroyOnLoad(gameObject);
            mainCanvasInstance = gameObject;  // ���̃I�u�W�F�N�g��ۑ�
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject uiElement in GameOverObject)
        {
            uiElement.SetActive(false);
        }
        UnityEngine.Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;  // �J�[�\�������b�N����

    }

    public void StartSceneTransition(string sceneName)
    {
        if (!isTransitioning)
        {
            StartCoroutine(SwitchScene(sceneName));
        }
    }
    public IEnumerator SwitchScene(string sceneName)
    {
        isTransitioning = true;
        Debug.Log("�t�F�[�h�J�n");
        yield return StartCoroutine(Fade(1.0f));//�t�F�[�h
        Debug.Log("�V�[���ړ�");
        SceneManager.LoadScene(sceneName);
        Debug.Log("�V�[���ړ�����");
        while (SceneManager.GetActiveScene().name != sceneName)
        {
            yield return null;
        }

        Debug.Log("UI�̔�\��");
        foreach (GameObject uiElement in mainUI)
        {
            uiElement.SetActive(false);
        }

        //  yield return null;
        //   Debug.Log("�t�F�[�h�J�n");
        yield return StartCoroutine(Fade(0.0f));
        Debug.Log("�t�F�[�h�I��");

        isTransitioning = false;
    }

    public IEnumerator FadeOutChangeScene(string sceneName)
    {
        isTransitioning = true;
        yield return StartCoroutine(Fade(2.0f));
        Debug.Log("�V�[���ړ�");
        SceneManager.LoadScene(sceneName);
        Debug.Log("�V�[���ړ�����");
        while (SceneManager.GetActiveScene().name != sceneName)
        {
            yield return null;
        }
        foreach (GameObject uiElement in GameOverObject)
        {
            uiElement.SetActive(true);
        }
        isTransitioning = false;
    }
    public IEnumerator Fade(float targetAlgha)
    {
        float startAlpha = fadeImage.color.a;
        float time = 0;

        while (time < fadeTime)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlgha, time / fadeTime);
            fadeImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        fadeImage.color = new Color(0, 0, 0, targetAlgha);

    }

    public void BackMain()
    {
        Debug.Log("MainCanvasInstance�j��");
        Destroy(mainCanvasInstance);
    }
}
