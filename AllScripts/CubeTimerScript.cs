using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeTimerScript : MonoBehaviour
{

    public float CubeGameTimer;

    public Text CubeGameTimerText;

    // Start is called before the first frame update
    void Start()
    {

        CubeGameTimer = 300.0f;


    }

    // Update is called once per frame
    void Update()
    {




        CubeGameTimer -= Time.deltaTime;



        int seconds = (int)(CubeGameTimer % 60);
        int minutes = (int)(CubeGameTimer / 60) % 60;


        string TimerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        CubeGameTimerText.text = TimerString;





        if (CubeGameTimer <= 0) 


        {

            Destroy(gameObject);


        }



    }
}
