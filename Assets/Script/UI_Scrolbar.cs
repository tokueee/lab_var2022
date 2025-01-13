using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Scrolbar : MonoBehaviour
{
    Scrollbar slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Scrollbar>();
    }

    public void Method()
    {
        Debug.Log("åªç›ílÅF" + slider.value);

        if (slider.value >= 50)
        {
            Debug.Log("50à»è„Ç≈Ç∑");
        }
    }
}
