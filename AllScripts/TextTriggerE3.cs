using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerE3 : MonoBehaviour
{


    public Text PressE3;




    void OnTriggerEnter(Collider other)

    {


        if (other.CompareTag("Player"))

        {


            PressE3.gameObject.SetActive(true);


        }


    }


    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Player"))

        {


            PressE3.gameObject.SetActive(false);



        }

    }

}