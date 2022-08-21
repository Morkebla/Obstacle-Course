using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float ellapsedTime = 3f;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        BlockVisibility();
    }

    // Update is called once per frame
    void Update()
    {
        BlockDropper();


    }
    void BlockDropper()
    {
        if (Time.time > ellapsedTime)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
    void BlockVisibility()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        renderer.enabled = false;
    }
}
