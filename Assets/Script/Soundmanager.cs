using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Soundmanager : MonoBehaviour
{
    public static Soundmanager instance;

    [SerializeField] AudioSource BGMSource;
    [SerializeField] float sfxVolume = 1.0f; // SFX—p‚Ì‰¹—Ê

    private void Awake()
    {
        instance = this;
    }

    public void SetBGMVolume(float volume)
    {
        BGMSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = volume;
    }

    public float GetSFXVolume()
    {
        return sfxVolume;
    }
}
