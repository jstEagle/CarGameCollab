using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float Speed = 5;
    public Rigidbody rb;

    private void Update()
    {
        transform.position = transform.position.x * Speed;
    }
}
