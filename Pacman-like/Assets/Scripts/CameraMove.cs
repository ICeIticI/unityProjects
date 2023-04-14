using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 1.0f;
    public Vector3 locationOffset = new Vector3(0,2,-3);
    public Vector3 rotationOffset = new Vector3(26,0,0);

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + target.rotation * locationOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        Quaternion desiredrotation = target.rotation * Quaternion.Euler(rotationOffset);
        Quaternion smoothedrotation = Quaternion.Lerp(transform.rotation, desiredrotation, smoothSpeed*0.9f);
        transform.rotation = smoothedrotation;
        //transform.rotation = desiredrotation;
    }
}
