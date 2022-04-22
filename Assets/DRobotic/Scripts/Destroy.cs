using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}