using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject parachute;
    public float drag = 3.0f;
    bool parachuteOpen = false;


    public float speed;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void FixedUpdate()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed;
        float sideMovement = Input.GetAxis("Horizontal") * speed;

        transform.Translate(sideMovement, 0, forwardMovement);
    }

    private void MouseMovement()
    {
    }
}
