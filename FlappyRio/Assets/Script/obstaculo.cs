using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public int mov;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - mov * Time.deltaTime, transform.position.y, transform.position.z);

        if (transform.position.x <= -5)
        {
            Destroy(gameObject);
        }
    }


}
