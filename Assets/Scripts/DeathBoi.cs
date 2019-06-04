using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerScript>().Die();
    }
}
