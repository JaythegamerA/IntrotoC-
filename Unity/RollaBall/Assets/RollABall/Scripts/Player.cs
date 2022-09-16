using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using TMPro;    // for TextMeshPro

public class Player : MonoBehaviour
{
    private Rigidbody rbody;
    private MeshRenderer meshRend;
    private AudioSource audioSrc;

    public TMP_Text scoreText;

    public List<AudioClip> boostSounds = new List<AudioClip>();

    public List<Material> colorMaterials = new List<Material>();
    private int currentColorIndex = 0;

    public float speed = 8.0f;

    public int points = 0;
    public float boostPower = 5.0f;

    // Time until you boost again
    public float boostCooldown = 5.0f;
    private float boostTimer = 0;

    private float horizontal = 0;
    private float forward = 0;

    //
    // IDamageable
    //

    public void TakeDamage(float damageTaken)
    {
        Debug.Log("DAMAGE TAKEN");
    }

    //
    // Unity Messages
    //

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        meshRend = GetComponent<MeshRenderer>();
        audioSrc = GetComponent<AudioSource>();
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
        horizontal = Input.GetAxisRaw("Horizontal");
        forward = Input.GetAxisRaw("Vertical");

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

            AudioClip selectedBoost = boostSounds[Random.Range(0, boostSounds.Count)];
            audioSrc.PlayOneShot(selectedBoost);
        }

        // score UI
        scoreText.text = points.ToString();
    }

    private void FixedUpdate()
    {
        Vector3 desiredMovement = new Vector3(horizontal, 0.0f, forward);
        desiredMovement = Vector3.ClampMagnitude(desiredMovement, 1);
        rbody.AddForce(desiredMovement * speed);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector3.right * Input.GetAxisRaw("Horizontal") * 2.0f);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, Vector3.forward * Input.GetAxisRaw("Vertical") * 2.0f);
    }
}