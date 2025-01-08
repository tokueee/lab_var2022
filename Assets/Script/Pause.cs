using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pause = false;
    [SerializeField] private GameObject OptionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!OptionCanvas.activeSelf) { TogglePause(); }
        }
    }


    private void PauseOn()
    {
        Time.timeScale = 0;
    }

    private void PauseOff()
    {
        Time.timeScale = 1;
    }
    public bool IsPaused()
    {
        return pause;
    }
    public void TogglePause()
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
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

}
