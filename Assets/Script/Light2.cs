using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    //Directional Light Rotation X = -13
    //S_,��K���C�g�@T_.�O�K���C�g
    [SerializeField] private GameObject[] firstfloorlight_h;//��K�L��
    [SerializeField] private GameObject[] firstfloorlight;//��K����    
    [SerializeField] private GameObject[] secondfloorlight_h;//��K�L��
    [SerializeField] private GameObject[] secondfloorlight;//��K����
    [SerializeField] private GameObject[] thirdfloorlight_h;//�O�K�L��
    [SerializeField] private GameObject[] thirdfloorlight;//�O�K����
    // Start is called before the first frame update
    void Start()
    {
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
