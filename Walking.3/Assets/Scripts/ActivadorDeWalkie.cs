using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ActivadorDeWalkie : MonoBehaviour
{


    public GameObject walkieVisual;

    public bool activa;

    public AudioSource quienEmite;
    public AudioClip elArchivoQueBaje;
    public float volumen = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0) && activa == true)
        {
            Debug.Log("Tomo objeto");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                walkieVisual.SetActive(true);
                
                transform.parent.gameObject.SetActive(false);


            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activa = true;
            quienEmite.PlayOneShot(elArchivoQueBaje, volumen);

        }

        //if (other.tag == "Player")
        //{
          //  quienEmite.PlayOneShot(elArchivoQueBaje,volumen);
       // }



    }

    
}
