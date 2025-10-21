using UnityEngine;

public class Ej3EventListener : MonoBehaviour
{
    [SerializeField] Ej3EventCaller caller;
    [SerializeField] GameObject target;
    void Start()
    {
        caller.CollisionEvent1 += OnEvento;
    }

    void OnEvento()
    {
        Vector3 direction = target.transform.position - transform.position;

        direction = direction.normalized;

        transform.position += direction;
    }

}
