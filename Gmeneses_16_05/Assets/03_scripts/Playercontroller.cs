using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 resetPosition;
    public int tentativas = 2;
    private bool collided = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            Vector3 force = new Vector3(0f, 0f, 200f);
            rb.AddForce(force);
            if (tentativas != 0)
            {
                Invoke("Reset", 5);
            }
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += transform.right * horizontal * Time.deltaTime;
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = resetPosition;
        collided = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!collided)
        {
            tentativas -= 1;
            collided = true;
        }       
    }
}
