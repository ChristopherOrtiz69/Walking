using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.SantyDev.Survival
{
    public class Interaction : MonoBehaviour
    {
        private void Awake()
        {

        }

        private void Start()
        {

        }

        private void OnEnable()
        {

        }

        private void Update()
        {
            CheckInput();

        }

        private void FixedUpdate()
        {

        }

        void CheckInput()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("Pressed");
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
                {
                    Debug.Log(hit.transform.name);
                }
            }
        }
    }
}
