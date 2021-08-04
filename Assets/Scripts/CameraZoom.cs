using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float minFOV;
    public float maxFOV;
    public float sensitivity;
    public float FOV;

    void Update()
    {
        FOV = Camera.main.fieldOfView;
        FOV += (Input.GetAxis("Mouse ScrollWheel") * sensitivity) * -1;
        FOV = Mathf.Clamp(FOV, minFOV, maxFOV);
        Camera.main.fieldOfView = FOV;
    }
}
