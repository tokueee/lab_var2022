using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pause = false;
    [SerializeField] private GameObject OptionCanvas;
    // Start is called before the first frame update

    public bool check_clear = true;//trueÇ™ÉQÅ[ÉÄPlayíÜ

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!OptionCanvas.activeSelf) { TogglePause(); }
        }
    }


    public void PauseOn()
    {
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        Time.timeScale = 1;
    }
    public bool IsPaused()
    {
        return pause;
    }
    public void TogglePause()
    {
        if (check_clear)//trueÇ™ÉQÅ[ÉÄPlayíÜ
        {
            pause = !pause;
            if (pause)
            {
                PauseOn();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                PauseOff();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

}
