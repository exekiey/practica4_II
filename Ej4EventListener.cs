using UnityEngine;

public class Ej4EventListener : MonoBehaviour
{
    [SerializeField] Ej4EventCaller caller;
    [SerializeField] GameObject target;
    void Start()
    {
        caller.ApproachEvent += OnEvento;
    }

    void OnEvento()
    {
        transform.position = target.transform.position;
    }
}
