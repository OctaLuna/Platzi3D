using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    //VARIABLES//
    //Esto es para medir la sensivilidad de la camara
    public float Sensitivity = 100f;

    //Transform es para medir la posicion de un objeto, en esta variable estamos nombrando un objeto como una variable
    public Transform Player1;

    //Es para la rotacion en eje X
    float xRotation = 0f;

    // Esto es el valor superior de el movimiento de la camara
    public float ValMax = 80f;

    //Esto es el valor inferior de el movimiento de la camara
    public float ValMin = -90f;



    // Start is called before the first frame update
    void Start()
    {
        //Esto bloque a el cursor al centro de la ventana del juego para que siempre este en la ventana del juego
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Imput.GetAxis("Mouse X"): esto es para llamar a las variables preinstaladas de Unity que se refiere al mouse y sus coordenadas
        // Sensitivity: es la variable de la sensivilidad de la camara
        // Time.deltaTime: esto es para medir el tiempo, deltaTime es para que el tiempo de carga sea igual en todas las Pc
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;

        // Imput.GetAxis("Mouse Y"): esto es para llamar a las variables preinstaladas de Unity que se refiere al mouse y sus coordenadas
        // Sensitivity: es la variable de la sensivilidad de la camara
        // Time.deltaTime: esto es para medir el tiempo, deltaTime es para que el tiempo de carga sea igual en todas las Pc
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        //Esto es para sacar el poder mover la camara
        xRotation -= mouseY;

        //Esto es para poner un limite en asi a donde puede llegar la cabeza
        //Mathf.Clamp es para poner limites a la camara
        //((xRotation, ValMin, ValMax) esto son las restricciones que pusimos en la camara, con el tema de movimiento
        xRotation = Mathf.Clamp(xRotation, ValMin, ValMax);

        //Esto es para medir las rotacion de la camara
        //transform es nuestra posicion en X, Y, Z
        //localRotation Esto es para rotar nuestra camara
        //QuaTernion es una estructura de datos para poder representar rotaciones
        //Euler(xRotation, 0f, 0f) limites de rotacion  esta en 0 para poder rotar 360°
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //esto es para pasar las instrucciones nuevas
        Player1.Rotate(Vector3.up * mouseX);

    }
}
