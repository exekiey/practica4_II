using TMPro;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    [SerializeField] float puntuacion;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI puntuacion100;


    private void Start()
    {
        text.text = puntuacion.ToString();
    }
    private void Update()
    {
        if (puntuacion >= 100)
        {
            puntuacion100.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shield1")
        {
            puntuacion += 5;
            Debug.Log(puntuacion);
            text.text = puntuacion.ToString();
        }

        if (other.gameObject.tag == "shield2")
        {
            puntuacion += 10;
            Debug.Log(puntuacion);
            text.text = puntuacion.ToString();
        }
    }
}
