using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody body;

    [SerializeField] float force;
    [SerializeField] float torqueForce;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        body.AddTorque(transform.up * Input.GetAxis("Horizontal") * torqueForce, ForceMode.VelocityChange);
        body.AddForce(transform.forward * Input.GetAxis("Vertical") * force);
    }
}
