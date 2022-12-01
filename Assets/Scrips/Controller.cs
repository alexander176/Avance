using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocidad;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
    void Movimiento()
    {
        float inputMovimiento= Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();


        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);
    }
    
}
