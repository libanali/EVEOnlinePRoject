using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerE : MonoBehaviour
{



    public Text PressE;




    void OnTriggerEnter(Collider other)

    {


        if (other.CompareTag("Player"))

        {


            PressE.gameObject.SetActive(true);


        }


    }


    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Player"))

        {


            PressE.gameObject.SetActive(false);



        }

    }

    }

