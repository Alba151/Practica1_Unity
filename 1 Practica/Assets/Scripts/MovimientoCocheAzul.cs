using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCocheAzul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimieto del coche hacia adelante
        transform.Translate(10 * Time.deltaTime * Vector3.forward);
    }
}
