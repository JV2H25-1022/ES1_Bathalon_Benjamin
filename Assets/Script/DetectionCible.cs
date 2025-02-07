using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCible : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Cible")){
            Destroy(gameObject);
        }
    }
}
