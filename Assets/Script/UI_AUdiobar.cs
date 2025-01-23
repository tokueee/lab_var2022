using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Audiobar : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetVolume(float volume)
    {
         //  Soundmanager.instance.SetBGMVolume(volume);
    }
    public void OnVolumeChange(float volume)
    {
        Debug.Log($"Volume changed to: {volume}");
        Soundmanager.instance.SetSFXVolume(volume);
    }
}
