using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour {
    //public GameObject objeto1;
    // Use this for initialization
    public GameObject OcultarCanvas1;
    public GameObject OcultarCanvas2;
    public GameObject panel;
    public static int  contador;
    
    
    
    void Start () {
        //Estrella.SetActive(false);
        //objeto1 = GameObject.Find("estrella");
        //objeto1.GetComponent<Renderer>().enabled = false;
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void inicioDelJuego()
    {
        SceneManager.LoadScene("inicioAnimadov1");
    }

    public void medallaSiluetas()
    {
        
        if (contador >= 3)
        {
            SceneManager.LoadScene("medallaSiluetas");
        } else{
            
            SceneManager.LoadScene("submenuDescubreElHabitat");
        }      
            
    }
    
        
    public void medallaRompecabeza()
    {
        
        
        if (contador >= 3)
        {
            SceneManager.LoadScene("medallaRompecabeza");
        } else{
            Inicio.contador=0;
            SceneManager.LoadScene("submenuCuidandoElBosque");
        }      
            
        
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }

    public void medallaPares()
    {
        
        
        
        if (contador >= 3)
        {
           SceneManager.LoadScene("medallaPares");
        } else{
            Inicio.contador=0;
            SceneManager.LoadScene("submenuEncuentraLosPares");
        }            
        
    }


    public void cambiar()
    {
        //Debug.Log("ddddd");
        Inicio.contador=0;
        SceneManager.LoadScene("menuJuegos");
    }
    public void DescubreElHabitat_Aves()
    {
        Inicio.contador+=1;
//        Debug.Log("Mira esto"+contador);
        SceneManager.LoadScene("juego1_aves");
               
        
    }
    public void DescubreElHabitat_Mamiferos()
    {
        Inicio.contador+=1;
//        Debug.Log("Mira esto"+contador);
        
        
        if (contador >= 3)
        {
            SceneManager.LoadScene("medallaSiluetas");
        } else{
            SceneManager.LoadScene("NewCombinados");
        }  
        
    }
    public void DescubreElHabitat_Arboles()
    {
        Inicio.contador+=1;

        
        
        
       
            SceneManager.LoadScene("juego1_arboles");
             
    }


    public void volverMenu()
    {
        //Debug.Log("ddddd");
        Inicio.contador=0;
        SceneManager.LoadScene("menuJuegos");
    }

    public void cambiarPajaros(int escenaMamiferos)
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene(escenaMamiferos);
    }

    public void cambiarMamiferos(int escenaPajaros)
    {
        //Debug.Log("ddddd");
        SceneManager.LoadScene(escenaPajaros);
    }


    public void PuzzleNivel1()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("JuegoRompecabeza");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;

    }

    public void PuzzleNivel2()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("SegundoNivelPuzzle");
        
        
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
       
    }
    public void PuzzleNivel3()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("TercerNivelPuzzle");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }


    public void submenuPares()
    {
        SceneManager.LoadScene("submenuEncuentraLosPares");
    }

    public void submenuCuidandoElBosque()
    {
        SceneManager.LoadScene("submenuCuidandoElBosque");
    }

    public void ParesNivel1()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("SampleScene");
    }

    public void ParesNivel2()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("SegundoNivel");
    }
    public void ParesNivel3()
    {
        Inicio.contador+=1;
        SceneManager.LoadScene("TercerNivel");
    }

    public void submenuDescubreElHabitat()
    {
        SceneManager.LoadScene("submenuDescubreElHabitat");
        Pieza.locked = false;
        Pieza2.locked = false;
        Pieza3.locked = false;
        Pieza4.locked = false;
        Pieza5.locked = false;
        Pieza6.locked = false;
        Pieza7.locked = false;
        Pieza8.locked = false;
        Pieza9.locked = false;
        Pieza10.locked = false;
        Pieza11.locked = false;
        Pieza12.locked = false;
    }
    
    public void Juego3()
    {
        SceneManager.LoadScene("juegoScene");
    }

    public void ayudaSilueta()
    {
        SceneManager.LoadScene("InfoJuegoSilueta");
    }


    public void ayudaPanelOn()
    {
        panel.SetActive(true);
        OcultarCanvas1.SetActive(false);
        OcultarCanvas2.SetActive(false);
    }

    public void ayudaPanelOff()
    {
        panel.SetActive(false);
        OcultarCanvas1.SetActive(true);
        OcultarCanvas2.SetActive(true);
    }

    public void VideoSilueta()
    {
        SceneManager.LoadScene("VideoSilueta");
    }
    public void VideoPuzzle()
    {
        SceneManager.LoadScene("VideoPuzzle");
    }
    public void VideoPares()
    {
        SceneManager.LoadScene("VideoPares");
    }
    public void salir()
    {
        //Debug.Log("ddddd");
        Application.Quit();
    }


}
