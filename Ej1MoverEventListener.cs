using UnityEngine;

public class Ej1MoverEventListener : MonoBehaviour
{
    [SerializeField] Ej1EventCaller eventosEj1;
    [SerializeField] GameObject objetivo;
    void Start()
    {
        eventosEj1.ColisionEvento += Mover;
    }

    void Mover()
    {

        Vector3 direction = objetivo.transform.position - transform.position;

        direction = direction.normalized;

        transform.position += direction;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
