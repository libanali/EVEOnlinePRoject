using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerE2 : MonoBehaviour
{

    public Text PressE2;




    void OnTriggerEnter(Collider other)

    {


        if (other.CompareTag("Player"))

        {


            PressE2.gameObject.SetActive(true);


        }


    }


    void OnTriggerExit(Collider other)
    {


        if (other.CompareTag("Player"))

        {


            PressE2.gameObject.SetActive(false);



        }



    }
}
