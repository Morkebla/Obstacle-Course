using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float moveSpeed = -15f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Printinstructions();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    void Printinstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your character with the arrow keys or W,A,S,D");

    }

    void PlayerMovement()
    {
        float zValue = Input.GetAxis("Vertical") * Time.fixedDeltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * moveSpeed;
        rigidbody.velocity = new Vector3(xValue, 0, zValue);
    }
}
