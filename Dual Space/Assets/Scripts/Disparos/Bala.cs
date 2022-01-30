using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(0f , 5f);

        if(gameObject != null)
        {
            Destroy(gameObject, 5f);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("marciano"))
        {
            Debug.Log("Colisiono Marciano");
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("meteorito"))
        {
            Debug.Log("Colisiono Meeteorito");
            Destroy(gameObject);

        }
    }
}
