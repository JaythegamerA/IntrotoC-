using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public Text ScoreText;

    public int points = 0;

    public float boostPower = 0;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       // Debug.Log("Player is initialized.");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Horizontal"))
        {
            rb.AddForce(
                horizontal = boostPower,
                0.00f,
                forward= boostPower,
                ForceMode.Impulse);
        }

 
        rb.AddForce(horizontal, 0.0f, forward);

        ScoreText.text= points.ToString();


        //Debug.Log("Player is updating!");
    }
}
