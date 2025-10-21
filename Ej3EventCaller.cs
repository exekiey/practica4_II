using UnityEngine;

public class Ej3EventCaller : MonoBehaviour
{
    public delegate void Colision();
    public event Colision CollisionEvent1;
    public event Colision CollisionEvent2;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "2")
        {
            CollisionEvent1();
        }
        if (collision.gameObject.tag == "1")
        {
            CollisionEvent2();
        }
    }
}
