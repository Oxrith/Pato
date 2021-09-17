using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recogerpistola : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject espadaSuelo;
    public GameObject espadaJugador;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Espada")
        {
            espadaSuelo.SetActive(false);
            espadaJugador.SetActive(true);
        }
    }
}
