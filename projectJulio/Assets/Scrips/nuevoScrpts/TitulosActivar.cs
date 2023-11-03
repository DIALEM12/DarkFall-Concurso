using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitulosActivar : MonoBehaviour
{
    public GameObject titulosActivar;
    
    //public GameObject efecto;
    

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            //Instantiate(efecto, transform.position, Quaternion.identity);
            
            
            Destroy(gameObject);
            titulosActivar.SetActive(true);
               

        }
    }
}
