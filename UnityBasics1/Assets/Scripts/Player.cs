using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            jumpKeyWasPressed = true;
        }
    }

    // fixedUpdate is called once every physcis update
    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
}
