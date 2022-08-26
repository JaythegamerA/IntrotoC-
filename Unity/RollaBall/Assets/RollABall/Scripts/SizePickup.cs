using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePickup : BasePickup
{
    public float newSize = 2.0f;

    protected override void ApplyPickup(Player target)
    {
        target.transform.localScale = Vector3.one * newSize;
    }
}