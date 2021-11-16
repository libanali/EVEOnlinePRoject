using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLightsForFakeCore1 : MonoBehaviour
{
    public Light FakeLight1;
    // Start is called before the first frame update
    void Start()
    {

        FakeLight1 = GetComponent<Light>();


        StartCoroutine(Flashing());


    }


    IEnumerator Flashing()

    {

        while (true)


        {

            yield return new WaitForSeconds(1.0f);

            FakeLight1.enabled = !FakeLight1.enabled;



        }



    }



}
