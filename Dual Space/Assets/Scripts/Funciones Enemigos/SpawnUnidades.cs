using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnidades : MonoBehaviour
{
    public GameObject marciano;
    public GameObject Meteoritos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMarcianos());
        StartCoroutine(SpawnMeteoritos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnMarcianos()
    {
        yield return new WaitForSeconds(2);

        Instantiate(marciano, new Vector3(Random.Range(-4f, 4f), 7f, 0), Quaternion.identity);

        StartCoroutine(SpawnMarcianos());

    }

    IEnumerator SpawnMeteoritos()
    {
        yield return new WaitForSeconds(4);

        Instantiate(Meteoritos, new Vector3(Random.Range(-4f, 4f), 7f, 0), Quaternion.identity);

        StartCoroutine(SpawnMeteoritos());

    }
}
