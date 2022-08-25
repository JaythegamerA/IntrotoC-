using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("the pick up was trigged");
        // did we collide with player
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            //if so give the player points
            player.points = player.points + 1;
            //destroy pick up
            Destroy(gameObject);
        }
        //if so give the player points
        //destroy pick up
        //other wise dont do anything 
    }
}
