using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //Directional Light Rotation X = -15
    //S_,��K���C�g�@T_.�O�K���C�g
    [SerializeField] private GameObject[] firstfloorlight_h;//��K�L��
    [SerializeField] private GameObject[] firstfloorlight;//��K����    
    [SerializeField] private GameObject[] secondfloorlight_h;//��K�L��
    [SerializeField] private GameObject[] secondfloorlight;//��K����
    [SerializeField] private GameObject[] thirdfloorlight_h;//�O�K�L��
    [SerializeField] private GameObject[] thirdfloorlight;//�O�K����

    SwichButton Swichb;
    [SerializeField] private GameObject swichb;
    // Start is called before the first frame update
    void Start()
    {
        Swichb = swichb.GetComponent<SwichButton>();
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
            if (Swichb.Sflag[i] == true && firstfloorlight[i].activeSelf == false)
            {
                firstfloorlight[i].SetActive(true);
            }
            else if (Swichb.Sflag[i] == false && firstfloorlight[i].activeSelf == true)
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
