using UnityEngine;

public class Ej5B : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cubo")
        {
            Destroy(gameObject);
        }
    }

}
