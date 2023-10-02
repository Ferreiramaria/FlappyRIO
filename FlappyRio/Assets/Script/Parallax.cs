using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    public float limiteX;
    public float posInicioX;
    private GameManager gM;
    
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <= limiteX)
        {
            transform.position = new Vector2(posInicioX, transform.position.y);
        }

        if (gM.IsGameOver == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
