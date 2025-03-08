using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    public AudioSource MySwooshSound;
    public AudioSource MyHitSound;
    public AudioSource MyPointSound;
    public bool MyHasBirdHitSomething;
    public float MyBirdSpeed;
    public ScoreScript MyScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        MyScoreScript = GameObject.Find("ScoreUI").GetComponent<ScoreScript>();
        MyRigidbody = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        MyRigidbody.MovePosition(transform.position + Vector3.right * Time.fixedDeltaTime * MyBirdSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            MyBirdSpeed = 5;
            Physics.gravity = new Vector3(0, -30, 0);
            MyRigidbody.linearVelocity = Vector3.zero;
            MyRigidbody.AddForce(0, 600, 0);
            MySwooshSound.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        MyBirdSpeed = 0;
        MyRigidbody.linearVelocity = Vector3.zero;
        Physics.gravity = Vector3.zero;

        MyHitSound.Play();

        Invoke("MyLoadScene", 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        MyPointSound.Play();
        MyScoreScript.AddToScore();
    }

    public void MyLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
