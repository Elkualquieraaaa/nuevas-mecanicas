using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientobola : MonoBehaviour
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
        transform.rotation = Quaternion.RotateTowards(transform.rotation, puntoC.rotation, velocity*Time.deltaTime);

        if (transform.rotation == puntoC.rotation)
        {
            if (transform.rotation == puntoA.rotation)
            {
                puntoC = puntoB;
            }
            if (transform.rotation == puntoB.rotation)
            {
                puntoC = puntoA;
            }
        }
    }
}

