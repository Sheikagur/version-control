using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>()
    }

    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal")
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
