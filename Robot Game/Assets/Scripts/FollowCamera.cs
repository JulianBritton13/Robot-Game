using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform playerShip;
    public Vector3 offset;

    void Update()
    {
        transform.position = playerShip.position + offset;
    }
}
