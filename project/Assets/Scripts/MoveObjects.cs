using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{

    public float speed;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
