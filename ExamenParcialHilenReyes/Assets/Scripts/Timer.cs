using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{

   public float time = 0;
   
   public TextMeshproUGUI TextoTimerPro;
    // Variable publica 
    void Update()
    {
        //Resta de tiempo 
        time -= Time.DeltaTime;
        TextoTimerPro.text = "" + timer.Tostring("f1"); 
        //"f1" decimales
    }
}
