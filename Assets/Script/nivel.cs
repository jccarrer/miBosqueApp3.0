﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel : MonoBehaviour
{
    [System.Obsolete]
    void OnMouseDown()
    {
        //Debug.Log("click");
        Inicio.contador+=1;
        Application.LoadLevel("SegundoNivel");//paa cambiar de ecena revisar porque esta deprecado]\


    }

}
