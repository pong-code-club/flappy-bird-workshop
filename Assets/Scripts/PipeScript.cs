using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject MyBird;

    void Start()
    {
        MyBird = GameObject.Find("Bird");
    }

    void Update()
    {
        if (transform.position.x < MyBird.transform.position.x - 10)
        {
            transform.position += new Vector3(30, 0, 0);
        }
    }
}
