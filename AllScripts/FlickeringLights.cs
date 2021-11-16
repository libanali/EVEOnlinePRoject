using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{



    public Light EmergencyLight;
    // Start is called before the first frame update
    void Start()
    {

        EmergencyLight = GetComponent<Light>();


        StartCoroutine(Flashing());
        
        
    }


    IEnumerator Flashing()

    {

        while (true)


        {

            yield return new WaitForSeconds(0.7f);

            EmergencyLight.enabled = !EmergencyLight.enabled;



        }



    }



}
