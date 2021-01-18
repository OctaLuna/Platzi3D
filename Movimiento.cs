using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //VARIABLES//

    //CharacterController es una clase de unity, esto te permite facilmente hacer movimientos en la escena
    public CharacterController controller;

    //esto es para medir la velocidad del jugador
    public float speed = 20f;



    // Update is called once per frame
    void Update()
    {
        //Esto es para asignar a una variable los botones que usara que Unity tiene preinstalada 
        //Input.GetAxis("") esto es para poder usar los botones que tiene Unity preasignadas, para usarlo lo puedes ver en Edit>Project Settings>Input Manager>Axes
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Esto es para mover el jugador en el eje, esto nos sirve para moverlo por el mundo
        //transform.right esto es para mover nuestro personaje en el eje X
        //transform.forward esto es para mover a nuestro personaje en el eje Z
        Vector3 movement = transform.right * x + transform.forward * z;

        //Esto es para mover al jugador, generar los deltas "delta son los cambios que tenemos" que tenemos 
        //controller es la variable ya asigna
        //Move() esto es para que nos podamos mover
        //(movement * speed * Time.deltaTime) lo que estamos haciendo en este lugar es multiplicar movement que es la variable Vecto3, speed que es la velocidad, Time.DeltaTime esto es el tiempo que pasa, el deltaTime es para que el tiemposea igual en todas las Pc
        controller.Move(movement * speed * Time.deltaTime);
    }
}
