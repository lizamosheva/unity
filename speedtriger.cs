using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedtriger : MonoBehaviour
{

    public float speedFactor = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}