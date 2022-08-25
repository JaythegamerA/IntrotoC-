using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using TMPro;    // for TextMeshPro

public class Player : MonoBehaviour
{
    private Rigidbody rbody;
    private MeshRenderer meshRend;

    public TMP_Text scoreText;

    public List<Material> colorMaterials = new List<Material>();
    private int currentColorIndex = 0;

    public int points = 0;
    public float boostPower = 5.0f;

    // Time until you boost again
    public float boostCooldown = 5.0f;
    private float boostTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        meshRend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // color swaps
        // if you press right bracket, next color
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            currentColorIndex++;
            if (currentColorIndex >= colorMaterials.Count)
            {
                currentColorIndex = 0;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }
        // otherwise if you press left bracket, previous color
        else if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            currentColorIndex--;
            if (currentColorIndex < 0)
            {
                currentColorIndex = colorMaterials.Count - 1;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }

        // movements
        float horizontal = Input.GetAxisRaw("Horizontal");
        float forward = Input.GetAxisRaw("Vertical");
        rbody.AddForce(horizontal, 0.0f, forward);

        // boost
        boostTimer -= Time.deltaTime;
        if (boostTimer <= 0.0f && Input.GetButtonDown("Boost"))
        {
            rbody.AddForce(
                horizontal * boostPower,
                0.0f,
                forward * boostPower,
                ForceMode.Impulse);

            boostTimer = boostCooldown;
        }

        // score UI
        scoreText.text = points.ToString();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector3.right * Input.GetAxisRaw("Horizontal") * 2.0f);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, Vector3.forward * Input.GetAxisRaw("Vertical") * 2.0f);
    }
}