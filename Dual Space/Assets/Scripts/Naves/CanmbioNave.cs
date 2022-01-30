using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanmbioNave : MonoBehaviour
{

    public GameObject naveNaranja;
    public GameObject naveVerde;

    // Start is called before the first frame update
    void Start()
    {
        naveVerde.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (naveVerde.activeInHierarchy)
            {
                naveVerde.SetActive(false);
                naveNaranja.transform.position = naveVerde.transform.position;
                naveNaranja.SetActive(true);
            } else
            {
                naveNaranja.SetActive(false);
                naveVerde.transform.position = naveNaranja.transform.position;
                naveVerde.SetActive(true);
            }
        }
    }
}
