using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrel : MonoBehaviour
{
    private PlayerController playerControllersScript;

    public float RotateSpeed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerControllersScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime * RotateSpeed);

        if (playerControllersScript.gameOver == false)
        {
            transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime * RotateSpeed);
        }
    }
}