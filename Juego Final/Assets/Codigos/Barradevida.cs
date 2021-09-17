using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{

    
    public Scrollbar barradevida;
 
    public float daño;
    float vida = 1;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barradevida.size = vida;

        if(vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }

        private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemigo")
        {
            vida -= daño;
        }
    }
}
