using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonBackToPosition : MonoBehaviour
{


    public Transform Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.CompareTag("EditorOnly"))


        {

            transform.position = Cube.transform.position;


        }
        
    }
}
