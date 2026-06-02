using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControleCrosshair : MonoBehaviour
{
    private RectTransform meuRectTransform;

    void Start()
    {
        meuRectTransform = GetComponent<RectTransform>();
        
        // Garante que a mira fique exatamente no centro do Canvas (meio da cena)
        if (meuRectTransform != null)
        {
            meuRectTransform.anchoredPosition = Vector2.zero;
        }
    }
}