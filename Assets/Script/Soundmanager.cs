using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Soundmanager : MonoBehaviour
{
    public static Soundmanager instance;

    [SerializeField] AudioSource BGMSource;

    private void Awake()
    {
        instance = this;
    }

    public void SetBGMVolume(float volume)
    {
        BGMSource.volume = volume;
    }
}
