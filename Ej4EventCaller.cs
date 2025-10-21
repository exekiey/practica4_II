using UnityEngine;

public class Ej4EventCaller : MonoBehaviour
{

    [SerializeField] GameObject target;
    [SerializeField] float minDistance;

    public delegate void Approach();
    public event Approach ApproachEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 distanceVector = target.transform.position - transform.position;

        if (distanceVector.magnitude < minDistance)
        {
            ApproachEvent();
        }
    }


    private void OnDrawGizmos()
    {
        /*
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, target.transform.position);

        Gizmos.color = Color.green;
        Vector3 distanceVector = target.transform.position - transform.position;
        Gizmos.DrawLine(transform.position, transform.position + distanceVector.normalized * minDistance);
        */
    }
}
