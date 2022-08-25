using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchpad : MonoBehaviour
{
    public float launchStrength = 15.0f;

    private void OnTriggerEnter(Collider other)
    {
        // did the player trigger us?
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            // if so, launch them
            Rigidbody playerRbody = other.GetComponent<Rigidbody>();
            playerRbody.AddForce(0, launchStrength, 0, ForceMode.Impulse);
        }

        // otherwise don't do anything
    }
}