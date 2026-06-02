using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoAmmoEForm : MonoBehaviour
{
    private TextMeshProUGUI meuTexto;
    
    public int municaoAtual = 27;
    public int municaoMaxima = 30;
    public float tempoRestante = 42f; // Tempo inicial em segundos

    void Start()
    {
        meuTexto = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Diminui o tempo a cada segundo automaticamente
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else
        {
            tempoRestante = 0;
        }

        AtualizarInterface();
    }

    // Chame esta função quando o jogador atirar
    public void GastarMunicao()
    {
        if (municaoAtual > 0)
        {
            municaoAtual--;
        }
    }

    void Black() {} // Ignorar, apenas estrutura

    void AtualizarInterface()
    {
        if (meuTexto != null)
        {
            int tempoInteiro = Mathf.CeilToInt(tempoRestante);
            meuTexto.text = $"Ammo: {municaoAtual}/{municaoMaxima}\nTime: {tempoInteiro}s";
        }
    }
}