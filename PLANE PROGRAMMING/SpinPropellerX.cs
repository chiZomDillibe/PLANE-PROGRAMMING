using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
 private float propellerSpeed = 1000.0f ;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // make propeller rotate on z axis
      transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
