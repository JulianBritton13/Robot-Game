using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float forwardSpeed = 100f;
    private void Start()
    {
        
    }
    void Update()
    {
       // player.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        player.AddRelativeForce(0, 0, forwardSpeed * Time.deltaTime);
    }
}
