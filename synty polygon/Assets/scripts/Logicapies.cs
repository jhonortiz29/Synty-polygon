using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logicapies : MonoBehaviour
{
    public PlayerMove logicaPersonaje;


    private void OnTriggerStay(Collider other)
    {
        logicaPersonaje.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        logicaPersonaje.puedoSaltar = false;
    }


}
