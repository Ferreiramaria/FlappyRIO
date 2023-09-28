using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    
    public int forçaPulo;
    private Rigidbody2D rbPlayer;
    public GameObject GameOver;
    public Animator anim;
    public AudioSource playerAudio;
    public AudioClip somPulo;
    public AudioClip moeda;
    public GameManager gM;
    public ParticleSystem fxPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        rbPlayer = GetComponent<Rigidbody2D>();
        rbPlayer.AddForce(new Vector2(0, forçaPulo), ForceMode2D.Impulse);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && gM.IsGameOver == false)
        {
            anim.SetBool("Pulou", true);
            rbPlayer.velocity = Vector2.zero;
            rbPlayer.AddForce(new Vector2(0, forçaPulo), ForceMode2D.Impulse);
            
            playerAudio.PlayOneShot(somPulo);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gM.IsGameOver = true;  
        GameOver.SetActive(true);
        fxPlayer.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moeda")
        {
            playerAudio.PlayOneShot(moeda);
            gM.pontuacao++;
            Debug.Log("Peguei uma moeda");
            Destroy(collision.gameObject);            
        }
    }
}
