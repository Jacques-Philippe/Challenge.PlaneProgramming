using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class SpinPropeller : MonoBehaviour
{
    private float rotationSpeed = 10000;

    private void Update()
    {
        
        this.transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed, Space.Self);
    }
}
