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
<<<<<<< HEAD
    MouseAction mactions;
    [SerializeField] private GameObject swichb;

=======
    [SerializeField] private GameObject swichb;
>>>>>>> 9a6da9b (ãƒœã‚¿ãƒ³æŠ¼ã—ã¦ãƒ©ã‚¤ãƒˆãŒã¤ãã‚ˆã†ã«ã—ãŸ)
    // Start is called before the first frame update
    void Start()
    {
        Swichb = swichb.GetComponent<SwichButton>();
<<<<<<< HEAD
        mactions = swichb.GetComponent<MouseAction>();
=======
>>>>>>> 9a6da9b (ãƒœã‚¿ãƒ³æŠ¼ã—ã¦ãƒ©ã‚¤ãƒˆãŒã¤ãã‚ˆã†ã«ã—ãŸ)
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
        for(int i = 0; i < Swichb.Sbutton.Length; i++)
        {
<<<<<<< HEAD
            if (firstfloorlight[i].activeSelf == false && mactions.count == 1)
            {
                firstfloorlight[i].SetActive(true);
            }
            else if (firstfloorlight[i].activeSelf == true && mactions.count == 0)
=======
            if (Swichb.Sflag[i] == true && firstfloorlight[i].activeSelf == false)
            {
                firstfloorlight[i].SetActive(true);
            }
            else if (Swichb.Sflag[i] == false && firstfloorlight[i].activeSelf == true)
>>>>>>> 9a6da9b (ãƒœã‚¿ãƒ³æŠ¼ã—ã¦ãƒ©ã‚¤ãƒˆãŒã¤ãã‚ˆã†ã«ã—ãŸ)
            {
                firstfloorlight[i].SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Swichb.Swichjudge() == true) { SwichLightOn(); }
    }
}
