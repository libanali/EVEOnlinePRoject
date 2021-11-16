using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AccessToPuzzle : MonoBehaviour
{
    public float Speedlevel;
    public float time;
    public GameObject Player;
    public GameObject Bolt1;
    public GameObject Bolt2;
    public GameObject Bolt3;
    public GameObject PC1;
    public GameObject PC2;
    public GameObject PC3;
    public GameObject PC4;
    public GameObject PC5;
    public GameObject PC6;
    public GameObject TextTrigger1;
    public Text E1;

    void Start()
    {

        Speedlevel = 1;
        time = 5f;
        PC1.SetActive(false);
        PC2.SetActive(false);
        PC3.SetActive(false);
        PC4.SetActive(false);
        PC5.SetActive(false);
        PC6.SetActive(false);

    }

    void Update()
    {
        time -= Time.deltaTime;

    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (Speedlevel == 1 && time <= 0)
            {
                Speedlevel = 2;
                time = 5f;
                Player.SetActive(false);
                Cursor.visible = true;
                Screen.lockCursor = false;
                Bolt1.SetActive(true);
                PC1.SetActive(true);
                E1.gameObject.SetActive(false);
                Destroy(TextTrigger1);


            }
            if (Speedlevel == 2 && time <= 0)
            {
                Speedlevel = 3;
                time = 5f;
                Player.SetActive(false);
                Cursor.visible = true;
                Screen.lockCursor = false;
                Bolt2.SetActive(true);
                PC2.SetActive(true);

            }
            if (Speedlevel == 3 && time <= 0)
            {
                Speedlevel = 4;
                time = 5f;
                Player.SetActive(false);
                Cursor.visible = true;
                Screen.lockCursor = false;
                Bolt3.SetActive(true);
                PC3.SetActive(true);

            }
            if (Speedlevel == 4 && time <= 0)
            {
                print("broken");

            }
        }
    }
}
    
