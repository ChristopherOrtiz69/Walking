using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class ActivadorDeNota : MonoBehaviour
{
    public GameObject notaVisual;
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
       if (Input.GetKeyDown(KeyCode.E)&& activa == true){
            notaVisual.SetActive(true);
            quienEmite.PlayOneShot(elArchivoQueBaje, volumen);
        }
       if (Input.GetKeyDown(KeyCode.Escape) && activa == true)
        {
            notaVisual.SetActive(false);
        }
           

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            activa = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activa = false;
            notaVisual.SetActive(false);

        }
    }
}
