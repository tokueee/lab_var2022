using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Brightness : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Scrollbar brightnessScrollbar;  // Scrollbarの参照
    [SerializeField] private Image brightnessOverlay;        // 画面全体を覆うImageの参照

    // Start is called before the first frame update
    public void brightness(float value)
    {
        brightnessOverlay.color = new Color(0, 0, 0, 1 - value);
    }
}
