using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{

    public GameObject panel;
    public bool activa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.E) && activa == true)
            {
                Debug.Log("Dialogo");
                panel.SetActive(true);

            }
            if (Input.GetKeyDown(KeyCode.Escape) && activa == true)
            {
                panel.SetActive(false);
            }

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activa = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activa = false;
            panel.SetActive(false);
        }
    }
}
