using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, 1) * rotationSpeed);
    }
}
