using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float turnSpeed1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates the spin propeller at the z-axis
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed1);
    }
}
