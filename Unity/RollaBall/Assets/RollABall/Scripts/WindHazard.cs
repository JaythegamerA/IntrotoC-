using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindHazard : BaseHazard
{
    public float windStrength = 10.0f;

    private Player affectedPlayer;

    // NOTE: this should really be FixedUpdate ...
    //       Terry should explain why later :P
    private void Update()
    {
        if (affectedPlayer != null)
        {
            // TODO: we can probably save this in a variable for later
            //       instead of getting it every update
            Rigidbody playerRbody = affectedPlayer.GetComponent<Rigidbody>();

            playerRbody.AddForce(0, 0, windStrength);
        }
    }

    protected override void OnPlayerEnter(Player target)
    {
        affectedPlayer = target;
    }

    protected override void OnPlayerExit(Player target)
    {
        affectedPlayer = null;
    }
}