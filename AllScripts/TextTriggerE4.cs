using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerE4 : MonoBehaviour
{
    public Text PressE4;




    void OnTriggerEnter(Collider other)

    {


        if (other.CompareTag("Player"))

        {


            PressE4.gameObject.SetActive(true);


        }


    }

    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Player"))

        {


            PressE4.gameObject.SetActive(false);



        }



    }
}