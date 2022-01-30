using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FunDeVicttoria : MonoBehaviour
{
    public int cantEnemigos = 20;
    public Text contadorDeEnemigos;
    // Start is called before the first frame update
    void Start()
    {
        contadorDeEnemigos.text = cantEnemigos.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        cantEnemigos = int.Parse(contadorDeEnemigos.text);

        if (cantEnemigos == 0)
        {
            SceneManager.LoadScene("sceneWin");
        }
    }
}
