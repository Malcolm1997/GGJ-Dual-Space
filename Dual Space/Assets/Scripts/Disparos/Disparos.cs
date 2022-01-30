using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    public GameObject bala;
    Vector2 bulletPos;
    public float fireRate = 0.4f;
    float nextFire = 0.0f;
    public AudioSource disparoSonido;
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            fire();           
        }
    }

    void fire()
    {
        disparoSonido.Play();
        bulletPos = transform.position;
        bulletPos += new Vector2(0f, +0.40f);
        Instantiate(bala, bulletPos, Quaternion.identity);
    }


}
