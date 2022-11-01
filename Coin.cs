using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int counterCoin = 0;
    private void OnTriggerEnter2D(Collider2D other) 
    {   
        if(counterCoin <= 3)//Moeda
        {
            if(other.tag == "Coin")
            {
                Debug.Log("Pegou");
                Destroy(other.gameObject, 0);
                counterCoin++;
                Debug.Log("Pegou " +counterCoin+ " moedas");
            }
        }
        else
        {
            Debug.Log("Não pode pegar mais moedas");
        }

        if(counterCoin == 4)//Porta
        {
            if(other.tag == "Door")
            {
                Debug.Log("Passou");
                counterCoin -= 4;
                Destroy(other.gameObject, 0);
            }
        }
    }
}