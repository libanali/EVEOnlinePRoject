using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Circuit : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    private int currentPoint;
    public GameObject Bolt1;
    public GameObject Bolt2;
    public GameObject Bolt3;
    public GameObject Timer;





    // Use this for initialization
    void Start()
    {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
        }

        if (currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            currentPoint = 0;
            Bolt1.transform.position = new Vector3(94.23734f, 14.68955f, -74.82625f);
            Bolt2.transform.position = new Vector3(171.0205f, 14.68955f, -74.72625f);
            Bolt3.transform.position = new Vector3(247.8205f, 14.68955f, -74.82625f);
            Timer.GetComponent<TimerScript>().GameTimer -= 10f;

        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Win")
        {
            Bolt1.SetActive(false);
            Bolt2.SetActive(false);
            Bolt3.SetActive(false);
        }
    }
}