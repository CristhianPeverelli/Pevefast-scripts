using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour{

    Animator animator;
    bool canMove;
   
    void Start(){
        animator = gameObject.GetComponent<Animator>();
        canMove = true;
    }

    void Update(){
        ProcessInput();
    }

    void ProcessInput(){

        if(Input.GetKey(KeyCode.A)){
            if(canMove){ moveLeft(); }
        }
        else if(Input.GetKey(KeyCode.D)){
            if(canMove){ moveRight(); }
        }

    }

    void moveLeft(){
        canMove = false;
        animator.SetBool("MoveToLeft",true);
        Invoke("endMov",0.33f);
    }

    void moveRight(){
        canMove = false;
        animator.SetBool("MoveToRight",true);
        Invoke("endMov",0.33f);
    }

    void endMov(){
        canMove = true;
        animator.SetBool("MoveToRight",false);
        animator.SetBool("MoveToLeft",false);
    }
}
