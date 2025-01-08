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
    public Language language;

    public Language SetLanguage(Language languages)
    {
        language = languages;
        return language;
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
