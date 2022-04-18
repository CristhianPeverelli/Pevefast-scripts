using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    Rigidbody rb;
    [SerializeField] float intensitaSterzata;
    [SerializeField] float intensitaBoost;
    [SerializeField] float intensitaRot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        ProcessInput();
    }

    void ProcessInput(){

        if(Input.GetKey(KeyCode.A)){
            moveLeft();
            rotateLeft();
        }
        else if(Input.GetKey(KeyCode.D)){
            moveRight();
            rotateRight();
        }

        if(Input.GetKey(KeyCode.Space)){
            boost();
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



}
