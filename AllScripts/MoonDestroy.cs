using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class MoonDestroy : MonoBehaviour
{



    public Transform Respawn; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {



        if(other.CompareTag("Finish"))

        {



            CameraShaker.Instance.ShakeOnce(3.7f, 3.7f, 1.0f, 1.0f);


            CameraShaker ShakeShake = GameObject.Find("FirstPersonCharacter").GetComponent<CameraShaker>();

            ShakeShake.enabled = true;


            transform.position = Respawn.transform.position;


        }
        
    }
}
