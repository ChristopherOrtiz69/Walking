using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisminuidorSeñal : MonoBehaviour
{

    VidaSeñal playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;

    public GameObject panel;

    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaSeñal>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            panel.SetActive(true);
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }

    }
}
