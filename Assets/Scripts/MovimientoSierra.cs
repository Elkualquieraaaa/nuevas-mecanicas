using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoSierra : MonoBehaviour
{
    [SerializeField] Transform puntoA, puntoB, puntoC;
    [SerializeField] float velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntoC.position, velocity * Time.deltaTime);

        if (transform.position == puntoC.position)
        {
            if (transform.position == puntoA.position)
            {
                puntoC = puntoB;
            }
            if (transform.position == puntoB.position) 
            {
                puntoC = puntoA;
            }
        }
    }
}
