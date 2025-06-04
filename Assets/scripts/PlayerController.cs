using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
                        //  x y z
        // transform.Translate(0,0,1); <-- una forma de moverlo hacia delante
        // transform.Translate(Vector3.forward);// <-- una forma mas sencilla
        // transform.Translate(Vector3.forward * Time.deltaTime);// <--normaliza la velocidad 1mt x segundo
        transform.Translate(Vector3.forward * Time.deltaTime *20);// <--normaliza la velocidad 20mt x segundo

    }
}
