using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.SantyDev.Survival
{
    public class Movement : MonoBehaviour
    {
        [Header("Variables")]
        private float x, z;
        private Vector3 dir;
        public float speed = 1;
        public float gravity;

        private void Update()
        {
            Move();
        }

        public void Move()
        {
            x = Input.GetAxisRaw("Horizontal");
            z = Input.GetAxisRaw("Vertical");

            dir.x = x;
            dir.z = z;
            dir.y = -gravity;


            GetComponent<CharacterController>().Move(transform.rotation*dir.normalized * Time.deltaTime * speed);
        }

       
    }
}
