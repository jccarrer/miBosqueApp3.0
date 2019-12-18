using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Threading;

public class DropPiezas3 : MonoBehaviour, IDropHandler
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
    public GameObject estrella1, estrella2, estrella3, estrella4, estrella5, estrella6, estrella7, estrella8, estrella9, estrella10, estrella11, estrella12;
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
            if ((eventData.pointerDrag.name == "pieza1") && (gameObject.name == "espacio1"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio1");
                encenderEstrellas();
                //cont = true;

                MusicSource.Play();
                contador++;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }

            if ((eventData.pointerDrag.name == "pieza2") && (gameObject.name == "espacio2"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio2");
                encenderEstrellas();

                //cont2 = true;

//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza3") && (gameObject.name == "espacio3"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio3");
                encenderEstrellas();

            }
            //cont2 = true;


            if ((eventData.pointerDrag.name == "pieza4") && (gameObject.name == "espacio4"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio4");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }



            if ((eventData.pointerDrag.name == "pieza5") && (gameObject.name == "espacio5"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio5");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }



            if ((eventData.pointerDrag.name == "pieza6") && (gameObject.name == "espacio6"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio6");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if((eventData.pointerDrag.name == "pieza7") && (gameObject.name == "espacio7"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio7");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza8") && (gameObject.name == "espacio8"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio8");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza9") && (gameObject.name == "espacio9"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio9");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza10") && (gameObject.name == "espacio10"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio10");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza11") && (gameObject.name == "espacio11"))
            {
                Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio11");
                encenderEstrellas();

                //cont2 = true;
//                Debug.Log(eventData.pointerDrag.name + "lo toco" + objeto1.name + "dddd" + contador);
            }


            if ((eventData.pointerDrag.name == "pieza12") && (gameObject.name == "espacio12"))
            {
                 Vector3 cantidadxyz = transform.position;
                Vector3 piezaxyz = SimpleDrag2.itemBeingDragged.transform.position;
                
                SimpleDrag2.itemBeingDragged.transform.position = cantidadxyz;
                SimpleDrag2.itemBeingDragged.transform.SetParent(transform.parent);
                Destroy(item);
                objeto1 = GameObject.Find("espacio12");
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
        else if (estrella8.activeSelf == false)
        {
            estrella8.SetActive(true);
        }
        else if (estrella9.activeSelf == false)
        {
            estrella9.SetActive(true);
        }
        else if (estrella10.activeSelf == false)
        {
            estrella10.SetActive(true);
        }
        else if (estrella11.activeSelf == false)
        {
            estrella11.SetActive(true);
        }
        else
        {
            estrella12.SetActive(true);
            MusicSource.clip = MusicEnseñanza;
            MusicSource.Play();
            Invoke("MyLoadingFunction", 3f);
        }
    }
    void MyLoadingFunction()
    {
//        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        panel.SetActive(true);
        OcultarCanvas1.SetActive(false);
        OcultarCanvas2.SetActive(false);
    }

}

