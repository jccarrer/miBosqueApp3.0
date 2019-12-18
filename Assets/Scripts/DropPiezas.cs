using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class DropPiezas : MonoBehaviour, IDropHandler
{
    public int valor = 5;
    public GameObject objeto1;
    public GameObject win;
    public GameObject panel;
    public GameObject OcultarCanvas1;
    public GameObject OcultarCanvas2;
    public int contador = 0;
    public int contarEncendidos;
    public GameObject estrella1, estrella2, estrella3, estrella4, estrella5, estrella6;
    // public AudioClip MusicClip;

    public AudioClip MusicClipError;
    public AudioSource MusicSource;
    public AudioClip MusicEnseñanza;


    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
//                Debug.Log("sdsdsdsd");
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            if ((eventData.pointerDrag.name == "pieza1") && (gameObject.name == "lugarpieza1"))
            {
               Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza1");

                encenderEstrellas();
                //Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
//                Debug.Log("Mira esto"+transform.childCount);
//                Debug.Log("Mira esto"+transform.position);

            }
            
            else if ((eventData.pointerDrag.name == "pieza2") && (gameObject.name == "lugarpieza2"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza2");
                encenderEstrellas();
                //cont2 = true;
                //Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
//                 Debug.Log("Base:"+cantidadxyz+ " y de pieza:"+piezaxyz);
            }

            else if ((eventData.pointerDrag.name == "pieza3") && (gameObject.name == "lugarpieza3"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza3");
                encenderEstrellas();
            }

            else if ((eventData.pointerDrag.name == "pieza4") && (gameObject.name == "lugarpieza4"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza4");
                encenderEstrellas();

                //cont2 = true;
                //Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            else if ((eventData.pointerDrag.name == "pieza5") && (gameObject.name == "lugarpieza5"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza5");
                encenderEstrellas();

                //cont2 = true;
                //Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            else if ((eventData.pointerDrag.name == "pieza6") && (gameObject.name == "lugarpieza6"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("lugarpieza6");
                encenderEstrellas();
                //cont2 = true;
                //Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }
            //contador++;
            //Debug.Log("ddddddddddddddddddddddddddddddddddd" + contador);


        }

        

    }



    public void encenderEstrellas()
    {
        contarEncendidos++;
        if (estrella1.activeSelf == false)
        {
            estrella1.SetActive(true);

        }
        else if (estrella2.activeSelf == false)
        {
            estrella2.SetActive(true);
        }
        else if (estrella3.activeSelf == false)
        {
            estrella3.SetActive(true);
        }
        else if (estrella4.activeSelf == false)
        {
            estrella4.SetActive(true);
        }
        else if (estrella5.activeSelf == false)
        {
            estrella5.SetActive(true);
            
        }
        else
        {
            estrella6.SetActive(true);
            MusicSource.clip = MusicEnseñanza;
            MusicSource.Play();
            Invoke("MyLoadingFunction", 3f);
        }
    }
    void MyLoadingFunction()
    {
        panel.SetActive(true);
        OcultarCanvas1.SetActive(false);
        OcultarCanvas2.SetActive(false);
//        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

}

