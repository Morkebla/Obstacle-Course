using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float xValue = 0f;
    [SerializeField] float yValue = 0.6f;
    float zValue = 0f;
    void Update()
    {
       transform.Rotate (xValue, yValue, zValue);
        
    }
}
