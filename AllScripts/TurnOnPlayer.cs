using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject PC1;
    public GameObject PC2;
    public GameObject PC3;
    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(true);
        PC1.SetActive(false);
        PC2.SetActive(false);
        PC3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
