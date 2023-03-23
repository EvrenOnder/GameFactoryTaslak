using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targetToFollow;
    public Vector3 targetOffset;

    private void LateUpdate()
    {
        transform.position = targetToFollow.position + targetOffset;
    }
}
