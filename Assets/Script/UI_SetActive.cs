using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_SetActive : MonoBehaviour
{
    [SerializeField] private GameObject PauseCanvas;
    [SerializeField] private GameObject OptionCanvas;
    [SerializeField] private Pause poseScript; // poseスクリプトの参照
    // Start is called before the first frame update
    void Start()
    {
        PauseCanvas.SetActive(false);
        OptionCanvas.SetActive(false);
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
            }
        }
        else
        {
            PauseCanvas.SetActive(false);
        }

    }
    public void PCamvas_Active()
    {
        PauseCanvas.SetActive(false);
    }

    public void OCamvas_Active()
    {
        OptionCanvas.SetActive(false);
    }


    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
}
