using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 5;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (float.Parse(string.Format("{0:F1}", transform.position.y)) > 0.5f) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector3.up * force;
        }
    }
}