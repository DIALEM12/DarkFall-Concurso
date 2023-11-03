using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitulosDesactivar : MonoBehaviour
{
    public GameObject titulosDesactivar;
    
    //public GameObject efecto;
    

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            //Instantiate(efecto, transform.position, Quaternion.identity);
            
            
            Destroy(gameObject);
            titulosDesactivar.SetActive(false);
               

        }
    }
}
