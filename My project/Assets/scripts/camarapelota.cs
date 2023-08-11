using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarapelota : MonoBehaviour
{
    // Atributo publico
    public Transform Pelota;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update() 
    {
        transform.position = new Vector3(
            Pelota.position.x,
            Pelota.position.y,
            -1); // posiciòn z        
    }
}
