using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoGameOver : MonoBehaviour
{
    private TextMeshProUGUI meuTexto;

    void Awake()
    {
        meuTexto = GetComponent<TextMeshProUGUI>();
       
        gameObject.SetActive(false); 
    }

    public void AtivarGameOver()
    {
        gameObject.SetActive(true);
        if (meuTexto != null)
        {
            meuTexto.text = "Game Over";
        }
    }
}