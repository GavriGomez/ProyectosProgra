using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;  //Declaramos un atributo
    private Animator MiAnimador;
   
    void Start()  //Mètodo
    {
        MiCuerpo = GetComponent<Rigidbody2D>(); //Invocacion
        MiCuerpo = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;
        MiCuerpo.velocity = new Vector3(5, velVert, 0);
        MiAnimador.SetBool("caminando", true);
        //El cuerpo va a tener una velocidad vectorial en esa direccion

    }
}
