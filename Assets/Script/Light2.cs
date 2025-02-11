using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //Directional Light Rotation X = -15
    //S_,“ñŠKƒ‰ƒCƒg@T_.OŠKƒ‰ƒCƒg
    [SerializeField] private GameObject[] firstfloorlight_h;//ˆêŠK˜L‰º
    [SerializeField] private GameObject[] firstfloorlight;//ˆêŠKº“à    
    [SerializeField] private GameObject[] secondfloorlight_h;//“ñŠK˜L‰º
    [SerializeField] private GameObject[] secondfloorlight;//“ñŠKº“à
    [SerializeField] private GameObject[] thirdfloorlight_h;//OŠK˜L‰º
    [SerializeField] private GameObject[] thirdfloorlight;//OŠKº“à

    SwichButton Swichb;
    MouseAction mactions;
    [SerializeField] private GameObject swichb;

    // Start is called before the first frame update
    void Start()
    {
        Swichb = swichb.GetComponent<SwichButton>();
        mactions = swichb.GetComponent<MouseAction>();
        Lightseting();
    }

    void Lightseting()
    {
        for (int i = 0; i < firstfloorlight.Length; i++)
        {
            firstfloorlight[i].SetActive(false);
        }
        for (int i = 0;i < secondfloorlight.Length; i++)
        {
            secondfloorlight[i].SetActive(false);
        }
        for(int i = 0; i <thirdfloorlight.Length; i++)
        {
            thirdfloorlight[i].SetActive(false);
        }
    }

    void SwichLightOn()
    {
        Debug.Log("ON");
        for(int i = 0; i < Swichb.Sbutton.Length; i++)
        {
            //ƒ‰ƒCƒg‚Ì‚Â‚¯Á‚µ‚ğ§Œä‚·‚éƒXƒNƒŠƒvƒg
            if (Swichb.Sflag[i] == true && firstfloorlight[i].activeSelf == false && mactions.count[i] == 1)
            {
                firstfloorlight[i].SetActive(true);
                Swichb.changemate(i);
            }
            else if (Swichb.Sflag[i] == false && firstfloorlight[i].activeSelf == true && mactions.count[i] == 0)
            {
                firstfloorlight[i].SetActive(false);
                //Swichb.Sflag[i] = false;
                Swichb.changemate(i);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Swichb.Getflag();
        //if(Swichb.Swichjudge() == true) { SwichLightOn(); }//‚¢‚¸‚ê‚©‚ÌSflag‚ªtrue‚Ì‚¾‚¯Às‚³‚¹‚é
    }
}
