using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Brightness : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Scrollbar brightnessScrollbar;  // Scrollbar‚ÌQÆ
    [SerializeField] private Image brightnessOverlay;        // ‰æ–Ê‘S‘Ì‚ğ•¢‚¤Image‚ÌQÆ

    // Start is called before the first frame update
    public void brightness(float value)
    {
        brightnessOverlay.color = new Color(0, 0, 0, 1 - value);
    }
}
