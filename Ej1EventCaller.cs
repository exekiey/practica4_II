using System.Data;
using UnityEngine;

public class Ej1EventCaller : MonoBehaviour
{
    public delegate void Colision();
    public event Colision ColisionEvento;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cubo")
        {
            ColisionEvento();
        }
    }

}
