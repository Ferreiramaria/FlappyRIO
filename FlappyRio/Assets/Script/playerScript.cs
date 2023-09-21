using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    
    public int forçaPulo;
    Rigidbody2D rbPlayer;
    public GameObject GameOver;
    public Animator anim;

    public AudioSource playerAudio;
    public AudioClip somPulo;
    public GameManager gM;
    
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        rbPlayer = GetComponent<Rigidbody2D>();
        rbPlayer.AddForce(new Vector2(0, forçaPulo), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && gM.IsGameOver == false)
        {
            rbPlayer.velocity = Vector2.zero;
            rbPlayer.AddForce(new Vector2(0, forçaPulo), ForceMode2D.Impulse);

            playerAudio.PlayOneShot(somPulo);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
