using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorJugador : MonoBehaviour
{
    //Declaramos una nueva variable para que brinque la pelota. Sirve como un par�metro que puede ser modificado desde Unity y ajustar el salto
    public float FuerzaSalto = 5;
    //Es una referencia al componente Rigidbody2D. Estamos poniendo una variable al codigo parsa poder aplicar f�sicas a la pelota
    //La variable solo est� declarada pero est� vac�a. Uso el metodo start para llenarla
    private Rigidbody2D miCuerpo;
    // Start is called before the first frame update
    void Start()
    {
        //start inicializa cosas en el juego
        //Obtengo el componente y lo guardo en la variable de referencia miCuerpo 
        miCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Podemos preguntar al usuario si presion� una tecla
        if (Input.GetButtonDown("Jump"))
        { //Si en este frame fu� presionado el bot�n para saltar
            print("Se presion� salto"); //ayuda a que se vea la instrucci�n en la consola
            miCuerpo.AddForce(
                new Vector3(0, FuerzaSalto, 0), ForceMode2D.Impulse);   //vectores en x, y y z
                //Estamos agregando la fuerza como una l�nea vectorial de 0 en x y una cantidad en y y 0 en z
                
            
    }
}
}
