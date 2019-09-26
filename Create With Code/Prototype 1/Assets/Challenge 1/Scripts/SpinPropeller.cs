using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float speed = 25f;
    private float rotationSpeed = 70f;
    private float verticalInput;
    private float rotatePropellar = 30f;

    // Update is called once per frame
    void Update()
    {
        //Rotates the propellar
        transform.Rotate(Vector3.forward * Time.deltaTime * rotatePropellar * 100);
    }
}
