using UnityEngine;

public class DemoBirdScript : MonoBehaviour
{
    public int MySpeed;
    public Rigidbody MyRigidbody;
    public ScoreScript MyScoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MySpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("mouse clicked");
            Physics.gravity = new Vector3(0, -30, 0);
            MyRigidbody.linearVelocity = new Vector3(0, 0, 0);
            MyRigidbody.AddForce(0, 600, 0);
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MyRigidbody.MovePosition(transform.position + Vector3.right * Time.deltaTime * MySpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter a trigger volume");
        MyScoreScript.AddToScore();
    }


}
