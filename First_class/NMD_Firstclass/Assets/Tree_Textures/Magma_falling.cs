using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma_falling : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.Range(0f, 5f), thrust, 0, ForceMode.Impulse);
    }
}