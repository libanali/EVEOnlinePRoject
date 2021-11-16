using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse2 : MonoBehaviour
{
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
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.visible = true;
                Screen.lockCursor = false;


            }
        }
    }
}
