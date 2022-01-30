using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FunMeterito : MonoBehaviour
{

    public Rigidbody2D rb2D;
    public float velocidadMeteorito = 15f;
    Vector2 desplazamientoMeteorito;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        desplazamientoMeteorito = new Vector2(Random.Range(-0.3f, 0.3f), Random.Range(-0.8f, -0.2f));
    }

    // Update is called once per frame
    void Update()
    {

        rb2D.AddForce(desplazamientoMeteorito * Time.deltaTime * velocidadMeteorito, ForceMode2D.Force);     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("pared"))
        {
            Destroy(gameObject);

        }


        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
