using UnityEngine;

[ExecuteInEditMode]
public class OrthographicCameraResizer : MonoBehaviour
{
    public Camera MyCamera;
    public float DesiredCameraWidth;

    void Start()
    {
        MyCamera = GetComponent<Camera>();
    }

    void Update()
    {
        MyCamera.orthographicSize = 0.5f * DesiredCameraWidth / MyCamera.aspect;
    }
}
