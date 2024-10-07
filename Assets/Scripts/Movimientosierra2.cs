using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientosierra2 : MonoBehaviour
{
    public List<Transform> objetivos= new List<Transform>();
    [SerializeField] float velocity;
    int objetivoactual = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivos[objetivoactual].position, velocity * Time.deltaTime);


        if (transform.position == objetivos[objetivoactual].position)
        {
            objetivoactual++;
            if (objetivoactual > objetivos.Count - 1)
            {
                objetivoactual = 0;
            }
        }
    }
}
