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
            //���C�g�̂������𐧌䂷��X�N���v�g
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
        //if(Swichb.Swichjudge() == true) { SwichLightOn(); }//�����ꂩ��Sflag��true�̎��������s������
    }
}
