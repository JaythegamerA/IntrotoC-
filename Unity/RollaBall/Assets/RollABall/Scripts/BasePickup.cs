using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // did we collide with a player?
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            // if so, do the pickup thing
            ApplyPickup(player);

            // then destroy the pickup
            Destroy(gameObject);
        }

        // otherwise, don't do anything
    }

    protected virtual void ApplyPickup(Player target)
    {
        // ... nothing ...
    }
} 