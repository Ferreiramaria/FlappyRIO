using UnityEngine;

public class obstaculo : MonoBehaviour
{
    
    public float verticalSpeed = 0.5f;
    public GameObject moeda1, moeda2, moeda3, moeda4;
    private GameManager gm;
    

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        moeda1.transform.position = new Vector2(moeda1.transform.position.x, Random.Range(2, -2));
        moeda2.transform.position = new Vector2(moeda2.transform.position.x, Random.Range(2, -2));
        moeda3.transform.position = new Vector2(moeda3.transform.position.x, Random.Range(2, -2));
        moeda4.transform.position = new Vector2(moeda4.transform.position.x, Random.Range(2, -2));
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.IsGameOver == false)
        {
            transform.position = new Vector3(transform.position.x - gm.mov * Time.deltaTime, transform.position.y, transform.position.z);

            float newY = transform.position.y + verticalSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            if (newY >= 2.23f)
            {
                verticalSpeed = -Mathf.Abs(verticalSpeed); // Inverte a direção vertical
            }

            if (newY <= -2f)
            {
                verticalSpeed = Mathf.Abs(verticalSpeed); // Inverte a direção vertical
            }
        }        

        if (transform.position.x <= -13.7f)
        {
            Destroy(gameObject);
        }
    }

   
}
