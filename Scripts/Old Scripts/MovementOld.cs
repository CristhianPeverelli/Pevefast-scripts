using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOld : MonoBehaviour{
/*
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] float intensitaSterzata;
    [SerializeField] float intensitaBoost;
    [SerializeField] float intensitaRot;
    [SerializeField] ParticleSystem sparkles;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        boost();
        ProcessInput();
    }

    void ProcessInput(){

        if(Input.GetKey(KeyCode.A)){
            intensitaBoost = intensitaBoost / 3;
            moveLeft();
            rotateLeft();
            intensitaBoost = intensitaBoost * 3;
        }
        else if(Input.GetKey(KeyCode.D)){
            intensitaBoost = intensitaBoost / 3;
            moveRight();
            rotateRight();
            intensitaBoost = intensitaBoost * 3;
        }

        if(Input.GetKey(KeyCode.Space)){
            sparkles.Play();
            if(!audioSource.isPlaying){
                audioSource.Play();
            }
        }else{
            audioSource.Stop();
        }

    }

    void moveRight(){
        rb.AddRelativeForce(intensitaSterzata * Time.deltaTime,0,0);
    }

    void moveLeft(){
        rb.AddRelativeForce(-intensitaSterzata * Time.deltaTime,0,0);
    }

    void rotateLeft(){
        rb.freezeRotation = true;
        transform.Rotate(0, -intensitaRot * Time.deltaTime, 0);
        rb.freezeRotation = false;
    }

    void rotateRight(){
        rb.freezeRotation = true;
        transform.Rotate(0, intensitaRot * Time.deltaTime, 0);
        rb.freezeRotation = false;
    }

    void boost(){
        rb.AddRelativeForce(0,0,intensitaBoost * Time.deltaTime);
    }
 */
}
