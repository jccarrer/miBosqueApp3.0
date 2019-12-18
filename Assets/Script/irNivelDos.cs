using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class irNivelDos : MonoBehaviour
{
    [System.Obsolete]
    void OnMouseDown()
    {
        Inicio.contador+=1;
        Application.LoadLevel("SegundoNivel");
    }
}
