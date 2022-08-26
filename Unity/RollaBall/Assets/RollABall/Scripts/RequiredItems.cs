using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequiredItems : MonoBehaviour
{
    // list of objects required
    public List<GameObject> required;

    // object to disable when all required objects are gathered
    public GameObject target;

    // the number of required objects obtained so far
    private int requiredCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        // is this on the list?
        bool isOnList = false;
        for (int i = 0; i < required.Count; ++i)
        {
            // is this the object we're looking for?
            if (required[i] == otherGO)
            {
                isOnList = true;
                break;
            }
        }

        // if so, increase our counter
        if (isOnList)
        {
            requiredCounter++;
        }

        // have we met the appropriate count to deactivate the target?
        if (requiredCounter == required.Count)
        {
            target.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject otherGO = other.gameObject;

        // is this on the list?
        bool isOnList = false;
        for (int i = 0; i < required.Count; ++i)
        {
            // is this the object we're looking for?
            if (required[i] == otherGO)
            {
                isOnList = true;
                break;
            }
        }

        // if so, decrement our counter
        if (isOnList)
        {
            requiredCounter--;
        }
    }
}