using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour{

    Animator animator;
    bool canMove;
    int actualColumn;
   
    void Start(){
        animator = gameObject.GetComponent<Animator>();
        canMove = true;
        actualColumn = 0;
    }

    void Update(){
        ProcessInput();
    }

    void ProcessInput(){

        if(Input.GetKey(KeyCode.A)){
            moveLeft();
        }
        else if(Input.GetKey(KeyCode.D)){
            moveRight();
        }

    }

    public void moveLeft(){
        if(canMove){ 
            if(actualColumn > -1){
                canMove = false;
                animator.SetBool("MoveToLeft",true);
                Invoke("endMov",0.33f);
                actualColumn--;
            }
        }
    }

    public void moveRight(){
        if(canMove){ 
            if(actualColumn < 1){
                canMove = false;
                animator.SetBool("MoveToRight",true);
                Invoke("endMov",0.33f);
                actualColumn++;
            }
        }
    }

    void endMov(){
        canMove = true;
        animator.SetBool("MoveToRight",false);
        animator.SetBool("MoveToLeft",false);
    }
}