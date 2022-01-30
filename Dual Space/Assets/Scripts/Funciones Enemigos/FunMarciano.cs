using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FunMarciano : MonoBehaviour
{
    public Rigidbody2D rb2D;
    float velocidadMarciano = 2f;
    public Text cantDeEnemigos;
    int enemigosRestantes;

    // Start is called before the first frame update
    void Start()
    {
        cantDeEnemigos = GameObject.Find("Timer (2)").GetComponent<Text>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 desplazamientoMarciano = new Vector2(0, -0.1f);
        enemigosRestantes = int.Parse(cantDeEnemigos.text);
        rb2D.AddForce(desplazamientoMarciano * Time.deltaTime * velocidadMarciano, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            enemigosRestantes = enemigosRestantes - 1;
            cantDeEnemigos.text = enemigosRestantes.ToString();
            Debug.Log("Colisiono Bala");
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
