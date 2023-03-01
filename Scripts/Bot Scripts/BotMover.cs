using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMover : MonoBehaviour{

    [SerializeField] int avanti; //1 avanti, 2 indietro
    [SerializeField] int speed;
    [SerializeField] int timeToStartMove;
    [SerializeField] float timePassed;
  
    void Start(){
        timePassed = 0;
    }

    void Update(){

        if(timePassed < timeToStartMove){
            timePassed += Time.deltaTime;
        }else{
            transform.Translate(Vector3.forward * Time.deltaTime * speed * -1, Space.World); 
        }
    }
}
