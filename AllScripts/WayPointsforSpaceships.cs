using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointsforSpaceships : MonoBehaviour
{


    public List<GameObject> wayPoints;

    public int startingwaypoint = 0;

    public float movementspeed = 3;

    private int currentwayPoint;

    // Start is called before the first frame update
    void Start()
    {


        currentwayPoint = startingwaypoint;
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 temporaryVector3 = Vector3.zero;

        temporaryVector3.x = wayPoints[currentwayPoint].transform.position.x;
        temporaryVector3.y = wayPoints[currentwayPoint].transform.position.y;
        temporaryVector3.z = wayPoints[currentwayPoint].transform.position.z;


        transform.LookAt(temporaryVector3);


        transform.Translate((Vector3.forward * movementspeed * Time.deltaTime));

        if( Vector3.Distance(transform.position, temporaryVector3) < movementspeed / 4)
        {

            currentwayPoint++;


            if(currentwayPoint > wayPoints.Count - 1)

            {

                currentwayPoint = startingwaypoint;
            }


        }
        
    }
}
