using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject obstaculo;
    
    private float intervalo;
    public float intervaloParaAd;

    public bool IsGameOver;
    public GameManager gM; 

    public int limitDificulty;

    public int pontuacao;
    public TextMeshProUGUI pontuacaoTMPro;

    public int mov;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        pontuacaoTMPro.text = pontuacao.ToString();

        if(pontuacao >= limitDificulty)
        {
            mov += 1;
            limitDificulty += 30;
        }

        if (intervalo <= Time.time && IsGameOver == false) 
        {
            Instantiate(obstaculo, new Vector3(6, Random.Range(-1.31f, 2), 0), Quaternion.identity);
            intervalo = Time.time + intervaloParaAd;
        }       
    }
}
