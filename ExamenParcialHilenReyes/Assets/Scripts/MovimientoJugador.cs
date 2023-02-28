using System.Collections;
using System.Collections.Generic;
using UnityEngine;
Using UnityEngineUI;

public class MovimientoJugador : MonoBehaviour
{
  
        Public float movespeed;
        Private vector3 moveInput;
    

    // Update is called once per frame
    void Update()
    {
        float horizontal = GetAxis.("horizontal");
        float vertical = GetAxis.("vertical");
    }
}
