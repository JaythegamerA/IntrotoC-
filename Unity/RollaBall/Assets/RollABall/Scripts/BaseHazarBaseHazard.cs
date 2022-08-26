using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            OnPlayerEnter(player);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            OnPlayerExit(player);
        }
    }

    protected virtual void OnPlayerEnter(Player target)
    {

    }

    protected virtual void OnPlayerExit(Player target)
    {

    }
}