using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AccessToPuzzle2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cam;
    public GameObject TextTrigger3;
    public Text E3;

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

                Cam.SetActive(true);
                Player.SetActive(false);
                Cursor.visible = true;
                Screen.lockCursor = false;
                Destroy(TextTrigger3);
                E3.gameObject.SetActive(false);

            }
        }
    }
}
