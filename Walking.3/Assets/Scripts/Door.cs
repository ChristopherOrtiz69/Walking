using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Transform door;
    public float doorSpeed = 1f;
    public bool isUnlocked = true;

    public Transform OpenTransform;
    public Transform ClosedTransform;
    Vector3 targetPosition;
    float time;
    



    void Start()
    {
        targetPosition = ClosedTransform.position;
    }

    // Update is called once per frames
    void Update() 
    {
        if ( isUnlocked && door.position != targetPosition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetPosition, time);
            time += Time.deltaTime * doorSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { 
            targetPosition = OpenTransform.position;
            time = 0;
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetPosition = ClosedTransform.position;
            time = 0;
        }
    }
}

