using UnityEngine;

public class ControllerClass : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    public float MySpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody>();
        MySpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyRigidbody.MovePosition(transform.position + Vector3.up * Time.deltaTime * MySpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MyRigidbody.MovePosition(transform.position + Vector3.down * Time.deltaTime * MySpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyRigidbody.MovePosition(transform.position + Vector3.left * Time.deltaTime * MySpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyRigidbody.MovePosition(transform.position + Vector3.right * Time.deltaTime * MySpeed);
        }
    }
}
