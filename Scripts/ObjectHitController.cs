using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHitController : MonoBehaviour{

    void Start(){
        
    }

    void Update(){
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Palla"){
            Debug.Log("palla presa!"); 
        }
    }
}
