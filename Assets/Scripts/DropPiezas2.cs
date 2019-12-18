using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class DropPiezas2 : MonoBehaviour, IDropHandler
{
    public int valor = 5;
    public GameObject objeto1;
    public GameObject win;
    public GameObject panel;
    public GameObject OcultarCanvas1;
    public GameObject OcultarCanvas2;

    public int contador = 0;
    public int contarEncendidos;
    // public AudioClip MusicClip;
    public GameObject estrella1, estrella2, estrella3, estrella4, estrella5, estrella6, estrella7, estrella8;
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
            if ((eventData.pointerDrag.name == "pieza1") && (gameObject.name == "espacioPieza1"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza1");
                encenderEstrellas();
                //cont = true;

                MusicSource.Play();
                contador++;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            if ((eventData.pointerDrag.name == "pieza2") && (gameObject.name == "espacioPieza2"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza2");
                encenderEstrellas();

                //cont2 = true;

//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza3") && (gameObject.name == "espacioPieza3"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza3");
                encenderEstrellas();

            }
            //cont2 = true;


            if ((eventData.pointerDrag.name == "pieza4") && (gameObject.name == "espacioPieza4"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza4");
                encenderEstrellas();
                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }



            if ((eventData.pointerDrag.name == "pieza5") && (gameObject.name == "espacioPieza5"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza5");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }



            if ((eventData.pointerDrag.name == "pieza6") && (gameObject.name == "espacioPieza6"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza6");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza7") && (gameObject.name == "espacioPieza7"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza7");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }



            if ((eventData.pointerDrag.name == "pieza8") && (gameObject.name == "espacioPieza8"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacioPieza8");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            contador++;
//            Debug.Log("ddddddddddddddddddddddddddddddddddd" + contador);


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
        else if (estrella6.activeSelf == false)
        {
            estrella6.SetActive(true);
        }
        else if (estrella7.activeSelf == false)
        {
            estrella7.SetActive(true);
        }
        else
        {
            estrella8.SetActive(true);
            MusicSource.clip = MusicEnseñanza;
            MusicSource.Play();
            Invoke("MyLoadingFunction", 3f);
        }
    }
    void MyLoadingFunction()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        panel.SetActive(true);
        OcultarCanvas1.SetActive(false);
        OcultarCanvas2.SetActive(false);
        
    }

}

