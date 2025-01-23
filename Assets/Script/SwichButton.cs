using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichButton : MonoBehaviour
{
    public GameObject[] Sbutton;
    public bool[] Sflag;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool Swichjudge()
    {
        for (int k = 0; k < Sbutton.Length; k++)
        {
            if (Sflag[k] == true)
            {
                flag = true;
                continue;
            }
        }
        return flag;
    }

    public bool SwichGetnum(int k)
    {
        if (Sbutton[k] && Sflag[k] == false)
        {
            Sflag[k] = true;
            //Debug.Log("good");
        }
        else if (Sbutton[k] && Sflag[k])
        {
            Sflag[k] = true;
        }
        return Sflag[k];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
