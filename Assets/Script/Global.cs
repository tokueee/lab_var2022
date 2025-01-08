using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//どのシーンでも使える変数用スクリプト
public class Global : MonoBehaviour
{
    public enum Language
    {
        Eng,
        Jpn
    }
    public static Language language;

    public void SetLanguage(Language languages)
    {
        language = languages;
    }

    public Language GetLanguage() { return language; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
