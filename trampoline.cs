using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength += 10;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
