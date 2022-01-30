using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direccion { Horizontal, Vertical}

public class Disparos : MonoBehaviour
{
    public Direccion DireccionArma = Direccion.Horizontal;
    public float Velocidad = 50.0F;

    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}