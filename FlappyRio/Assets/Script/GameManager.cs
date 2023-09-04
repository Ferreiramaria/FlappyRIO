using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstaculo;
    private float intervalo;
    public float intervaloParaAd;
    
    // Start is called before the first frame update
    void Start()
    {
        intervalo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (intervalo <= Time.time)
        {
            Instantiate(obstaculo, new Vector3(6, Random.Range(-1.31f, 2), 0), Quaternion.identity);
            intervalo = Time.time + intervaloParaAd;
        }
       
    }
}
