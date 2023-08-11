using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorJugador : MonoBehaviour
{
    //Declaramos una nueva variable para que brinque la pelota. Sirve como un paràmetro que puede ser modificado desde Unity y ajustar el salto
    public float FuerzaSalto = 5;
    //Es una referencia al componente Rigidbody2D. Estamos poniendo una variable al codigo parsa poder aplicar fìsicas a la pelota
    //La variable solo està declarada pero està vacìa. Uso el metodo start para llenarla
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
        //Podemos preguntar al usuario si presionò una tecla
        if (Input.GetButtonDown("Jump"))
        { //Si en este frame fuè presionado el botòn para saltar
            print("Se presionò salto"); //ayuda a que se vea la instrucciòn en la consola
            miCuerpo.AddForce(
                new Vector3(0, FuerzaSalto, 0), ForceMode2D.Impulse);   //vectores en x, y y z
                //Estamos agregando la fuerza como una lìnea vectorial de 0 en x y una cantidad en y y 0 en z
                
            
    }
}
}
