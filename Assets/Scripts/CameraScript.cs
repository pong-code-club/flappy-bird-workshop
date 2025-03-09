using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject MyBird;
    public Camera MyCamera;
    //public float DesiredCameraWidth;

    void Start()
    {
        MyBird = GameObject.Find("Bird");
    }

    void Update()
    {
        transform.position = new Vector3(MyBird.transform.position.x, 0, transform.position.z);
    }
}
