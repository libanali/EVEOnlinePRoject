using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using EZCameraShake;
public class TimerScript : MonoBehaviour
{



    public Text GameTimerText;

    public float GameTimer;

    private bool testing = false;

    public GameObject[] EmergencyLights;

    public GameObject EvilLaughhh;

    public GameObject EvilLaugh2;




    // Use this for initialization
    void Start()
    {


        GameTimer = 300.0f;

    }

    // Update is called once per frame
    void Update()
    {



        GameTimer -= Time.deltaTime;



        int seconds = (int)(GameTimer % 60);
        int minutes = (int)(GameTimer / 60) % 60;


        string TimerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        GameTimerText.text = TimerString;






        if (GameTimer <= 90.0)


        {


            CameraShaker.Instance.ShakeOnce(1.7f, 1.7f, 1.0f, 1.0f);


            CameraShaker ShakeShake = GameObject.Find("FirstPersonCharacter").GetComponent<CameraShaker>();

            ShakeShake.enabled = true;



        }





        if (GameTimer <= 89.0)

        {


            EmergencyLights[0].SetActive(true);
            EmergencyLights[1].SetActive(true);
            EmergencyLights[2].SetActive(true);
            EmergencyLights[3].SetActive(true);
            EmergencyLights[4].SetActive(true);
            EmergencyLights[5].SetActive(true);
            EmergencyLights[6].SetActive(true);
            EmergencyLights[7].SetActive(true);
            EmergencyLights[8].SetActive(true);
            EmergencyLights[9].SetActive(true);
            EmergencyLights[10].SetActive(true);
            EmergencyLights[11].SetActive(true);
            EmergencyLights[12].SetActive(true);
            EmergencyLights[13].SetActive(true);
            EmergencyLights[14].SetActive(true);
            EmergencyLights[15].SetActive(true);
            EmergencyLights[16].SetActive(true);
            EmergencyLights[17].SetActive(true);
            EmergencyLights[18].SetActive(true);
            EmergencyLights[19].SetActive(true);
            EmergencyLights[16].SetActive(true);
            EmergencyLights[17].SetActive(true);
            EmergencyLights[18].SetActive(true);
            EmergencyLights[19].SetActive(true);
            EmergencyLights[20].SetActive(true);
            EmergencyLights[21].SetActive(true);
            EmergencyLights[22].SetActive(true);
            EmergencyLights[23].SetActive(true);
            EmergencyLights[24].SetActive(true);
            EmergencyLights[25].SetActive(true);
            EmergencyLights[26].SetActive(true);
            EmergencyLights[27].SetActive(true);
            EmergencyLights[28].SetActive(true);
            EmergencyLights[29].SetActive(true);
            EmergencyLights[30].SetActive(true);
            EmergencyLights[31].SetActive(true);
            EmergencyLights[32].SetActive(true);
            EmergencyLights[33].SetActive(true);
            EmergencyLights[34].SetActive(true);
            EmergencyLights[35].SetActive(true);
            EmergencyLights[36].SetActive(true);
            EmergencyLights[37].SetActive(true);
            EmergencyLights[38].SetActive(true);
            EmergencyLights[39].SetActive(true);
            EmergencyLights[40].SetActive(true);
            EmergencyLights[41].SetActive(true);
            EmergencyLights[42].SetActive(true);
            EmergencyLights[43].SetActive(true);


        }






        if (GameTimer <= 85.0)


        {



            EvilLaughhh.gameObject.SetActive(true);


            }



        if(GameTimer <= 71.0)

        {


            EvilLaugh2.gameObject.SetActive(true);

        }




            if (GameTimer <= 0.0)


            {


                SceneManager.LoadScene("Retry Screen");


            }



        }

    }


   







    









