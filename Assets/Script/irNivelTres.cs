using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irNivelTres : MonoBehaviour
{
    [System.Obsolete]
    void OnMouseDown()
    {
        //Debug.Log("click");
        Inicio.contador+=1;
        Application.LoadLevel("TercerNivel");//paa cambiar de ecena revisar porque esta deprecado]\


    }
}
