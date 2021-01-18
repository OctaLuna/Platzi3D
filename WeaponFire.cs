using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    //VARIABLES//

    //este es el daño que ara nuestra arma
    public float damage = 1f;

    //es el rango de nuestra pistola, que tan lejos va a llegar la bala
    public float range = 100f;

    //
    public Camera PlayerCam;



    // Update is called once per frame
    void Update()
    {
        //Es
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //esta nueva funcion es para medir el disparar
    void Shoot()
    {
        //Esta es una estructura que se usa para retornar la informacion a que cosa le pego la bala
        RaycastHit hit;
        
        //Esto es para detectar si hubo una colicion con el disparo
        //Raycast lanza el rayo
        //PlayerCam es la variable creada 
        //transform.position es la posicion 
        //PlayerCam.transform.forward esto es para que la bala salga frente a la camara
        //out hit en esta parte le decimos que va a almacenar la informacion en hit que es una variable
        //range le damos el rango que queremos que tenga es una variable creada previamente
        if(Physics.Raycast(PlayerCam.transform.position, PlayerCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
        }
    }
}
