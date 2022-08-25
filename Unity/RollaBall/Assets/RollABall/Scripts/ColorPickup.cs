using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : MonoBehaviour
{
    public Material rewardMaterial;

    // detect when the player has picked up the pickup
    // if so, give them a new color
    //        and then destroy ourselves
    // if not, do nothing

    private void OnTriggerEnter(Collider other)
    {
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            player.colorMaterials.Add(rewardMaterial);

            Destroy(gameObject);
        }
    }
}