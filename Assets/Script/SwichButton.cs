using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichButton : MonoBehaviour
{
    public GameObject[] Sbutton;
    public bool[] Sflag;
    bool flag;
    private Renderer[] brend;
    // Start is called before the first frame update
    void Start()
    {
        brend = new Renderer[Sbutton.Length];//Sbutton�̐����Q��
        for (int i = 0; i < Sbutton.Length; i++)
        {
            brend[i] = Sbutton[i].GetComponent<Renderer>();
        }
        Sflag = new bool[Sbutton.Length];//Sbutton�̐����Q��
    }

    public bool Swichjudge()
    {
        for (int k = 0; k < Sbutton.Length; k++)
        {
            if (Sflag[k] == true)
            {
                flag = true;
            }
            else if (Sflag[k] == false)
            {
                flag = false;
            }
        }
        Debug.Log(flag);
        return flag;
    }


    public bool SwichGetnum(int k)
    {
        if (Sbutton[k] && Sflag[k] == false)
        {
            Sflag[k] = true;
            Debug.Log(Sflag[k]);
        }
        else if (Sbutton[k] && Sflag[k])
        {
            Sflag[k] = false;
        }
        return Sflag[k];
    }

    public void changemate(int h)
    {
        //���C�g�̂������ŐF�ύX
        if (Sflag[h] == true)
        {
            brend[h].material.color = Color.white;//Light ON
        }
        else if (Sflag[h] == false)
        {
            brend[h].material.color = Color.red;//Light Off
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
