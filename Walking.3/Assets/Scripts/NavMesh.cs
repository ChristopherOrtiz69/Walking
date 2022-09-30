using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMesh : MonoBehaviour
{
    Vector3 startPos;
    public GameObject tgt;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        GetComponent<NavMeshAgent>().SetDestination(tgt.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "target")
        {
            print("d");
            GetComponent<NavMeshAgent>().SetDestination(startPos);
        }
    }
}
