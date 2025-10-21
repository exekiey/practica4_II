using UnityEngine;

public class Ej4EventListenerB : MonoBehaviour
{
    [SerializeField] Ej4EventCaller caller;
    [SerializeField] GameObject target;
    void Start()
    {
        caller.ApproachEvent += OnEvento;
    }

    void OnEvento()
    {

        Vector3 watchDirection = target.transform.position - transform.position;

        transform.forward = watchDirection;
    }
}
