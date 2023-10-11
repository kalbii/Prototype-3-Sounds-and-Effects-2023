using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float JumpForce = 10.0f;
    public float GravityMod = 0.0f;

    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.AddForce(Vector3.up * 1000);
        Physics.gravity *= GravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
