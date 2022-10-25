using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour{

    Animator animator;
    int actColumn;
    bool canMove;
   
    void Start(){
        actColumn = 0;
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
        if(actColumn > -1){
            canMove = false;
            animator.SetBool("MoveToLeft",true);
            Invoke("endMov",0.33f);
            actColumn--;
        }
    }

    void moveRight(){
        if(actColumn < 1){
            canMove = false;
            animator.SetBool("MoveToRight",true);
            Invoke("endMov",0.33f);
            actColumn++;
        }
    }

    void endMov(){
        canMove = true;
        animator.SetBool("MoveToRight",false);
        animator.SetBool("MoveToLeft",false);
    }
}
