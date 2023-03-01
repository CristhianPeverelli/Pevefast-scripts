using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour{

    AudioSource audioSource;

    [SerializeField] AudioClip crash;
    [SerializeField] ParticleSystem crashParticle;

    private void OnTriggerEnter(Collider other) {
    //    GetComponent<Movement>().enabled = false;
        audioSource.PlayOneShot(crash);
        crashParticle.Play();
        Invoke("ReloadLevel",1f);
    }

   void ReloadLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        GetComponent<Movement>().enabled = true;
    }

}
