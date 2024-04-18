using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTutorial : MonoBehaviour
{
    public float rangoAlerta;
    public LayerMask jugadorCapa;
    public Transform jugador;
    public float velocidad;

    bool enemigoAlerta;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemigoAlerta = Physics.CheckSphere(transform.position, rangoAlerta, jugadorCapa);

        if(enemigoAlerta == true)
        {
            //transform.LookAt(jugador);
            Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, rangoAlerta);
    }
}
