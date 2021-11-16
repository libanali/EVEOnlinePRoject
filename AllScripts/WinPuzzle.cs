using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPuzzle : MonoBehaviour
{
    public GameObject Player;
    public GameObject Timer;
    public GameObject PC1;
    public GameObject PC2;
    public GameObject PC3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bolt")
        {
            Destroy(other);
            Player.SetActive(true);
            Timer.GetComponent<TimerScript>().GameTimer = 300f;
            PC1.SetActive(false);
            PC2.SetActive(false);
            PC3.SetActive(false);
        }
    }
}
