using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float Strength;
    public Vector3 WindDirection;

    void OnTriggerStay(Collider body)
    {
        if(body.gameObject.CompareTag("Player"))
        {
            Rigidbody colRigidbody = body.GetComponent<Rigidbody>();
            if (colRigidbody != null)
            {
                colRigidbody.AddForce(WindDirection * Strength);
            }
        }      
    }

    private void OnTriggerExit(Collider body)
    {
        if (body.gameObject.CompareTag("Player"))
        {
            Rigidbody colRigidbody = body.GetComponent<Rigidbody>();
            colRigidbody.velocity = Vector3.zero;
            colRigidbody.angularVelocity = Vector3.zero;
        }
        
    }
}
