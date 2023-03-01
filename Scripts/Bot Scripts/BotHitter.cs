using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHitter : MonoBehaviour{

    Rigidbody rb;
    AudioSource audioSource;

    [SerializeField] AudioClip crash;
    [SerializeField] ParticleSystem crashParticle;

    void Start(){
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnCollisionEnter(Collision other) {

        switch(other.gameObject.tag){

            case "RailwayNoHit":
                Debug.Log("Un bot ha colpito un muro!");
            break;
            case "Player":
                audioSource.PlayOneShot(crash);
                crashParticle.Play();
            break;

        }
    }
}
