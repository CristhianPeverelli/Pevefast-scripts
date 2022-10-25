using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHitController : MonoBehaviour{

    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player"){
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }

}
