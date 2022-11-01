using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlappy : MonoBehaviour
{

    Rigidbody _rigidbody;
    public float force;

    // Start is called before the first frame update
    void Start()
    {

        _rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        }

    }
}
