using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;

    public float boundX = .15f;
    public float boundY = .05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
    }
}
