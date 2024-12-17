using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;


public class CameraNoise : MonoBehaviour
{  
    
    //MainCamera�ɃA�^�b�`����NoiseMate��ݒ肷��
    public Material noiseMaterial;
    /*[Range(0, 1)]
    private float noiseAmount = 0.1f;//public�̗D��x����������public���g���Ă��Ȃ�
    private Color noiseColor = Color.white;

    private float timer;
    private float set_time;
    private float times = 6.0f;
    private bool oneTime = false;*/
    private float Transparency;

    public void setTrans(float num){ Transparency = num;}

    public float getTrans(){ return Transparency;}
    void Start()
    {
    }
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (noiseMaterial != null)
        {
            // �m�C�Y�̋����𒲐�
            //noiseMaterial.SetFloat("_NoiseAmount", noiseAmount);

            //noiseMaterial.SetColor("_NoiseColor", noiseColor);
            //Debug.Log(noiseColor);
            noiseMaterial.SetFloat("_Transparency", Transparency);
            // �m�C�Y�G�t�F�N�g���J�����̃����_�����O�ɓK�p
            Graphics.Blit(src, dest, noiseMaterial);
            
        }
        else
        {
            // �m�C�Y�}�e���A�����Ȃ��ꍇ�͂��̂܂ܕ`��
            Graphics.Blit(src, dest);
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        /*timer = Time.time;
        set_time = timer % 11;
        if(set_time > times && oneTime == false)
        {
            oneTime = true;
            noiseColor = Color.red;
        }else if(set_time < times && oneTime == true)
        {
            oneTime= false;
            noiseColor = Color.white;
        }
        Debug.Log(set_time);*/

    }
}
