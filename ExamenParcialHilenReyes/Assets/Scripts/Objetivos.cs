using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{


    Void star ()
    {
        createObjet();

    }
    Private void  createObjet()
    {
        createdOject=Instantiate(ObjetctoCreate, position.transform);
        Invoke ("DestroyObjetc", 2f);

        
    }
    Private void destroyObjet ()
    {
        DestroyObjetc(createObjet);
        Invoke ("createObjet", 2f);
    }


    
}
