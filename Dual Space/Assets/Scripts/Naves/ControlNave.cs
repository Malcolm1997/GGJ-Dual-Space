using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
public class ControlNave : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float velocidad = 120f;

    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 desplazamientoNave = new Vector2(movimientoHorizontal, movimientoVertical);

        rb2D.AddForce(desplazamientoNave * Time.deltaTime * velocidad, ForceMode2D.Impulse);

    }


}
