using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourWinTheGame : MonoBehaviour
{
    public GameObject Block_One;
    private float Block_One_z;

    public GameObject Block_Two;
    private float Block_Two_z;

    public GameObject Block_Three;
    private float Block_Three_z;

    public GameObject Block_Four;
    private float Block_Four_z;


    public GameObject End_Off;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Block_One_z = Block_One.transform.rotation.eulerAngles.z;
        Block_Two_z = Block_Two.transform.rotation.eulerAngles.z;
        Block_Three_z = Block_Three.transform.rotation.eulerAngles.z;
        Block_Four_z = Block_Four.transform.rotation.eulerAngles.z;


        CheckIfCorrect();
    }



    void CheckIfCorrect()
    {

        if (Block_One_z == 0 && (Block_Two_z == 90 || Block_Two_z == 270) && Block_Three_z == 270 && Block_Four_z == 180)
            {

            //print("All Good");


            Destroy(End_Off);

        }



    }
}