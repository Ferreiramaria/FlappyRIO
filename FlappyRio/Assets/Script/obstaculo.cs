using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public int mov;
    public float verticalSpeed = 0.5f;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - mov * Time.deltaTime, transform.position.y, transform.position.z);
        
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

        if (transform.position.x <= -5)
        {
            Destroy(gameObject);
        }
    }


}
