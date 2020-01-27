using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject parachute;
    public float drag = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            parachute.gameObject.SetActive(true);
            this.GetComponent<Rigidbody>().drag = drag;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, -10, 0);
        }
    }
}
