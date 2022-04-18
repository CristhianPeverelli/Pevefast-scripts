using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMover : MonoBehaviour
{

    [SerializeField] float zValue;
    [SerializeField] float xValue;
    [SerializeField] int velocita;
    [SerializeField] bool left;
    [SerializeField] bool drifta;
  
    void Start()
    {
        xValue = 0;
        zValue = 0.01f * velocita;
    }

    void Update()
    {   
        if(drifta){
            if(Time.time > 3){

                if(Time.time > 4){
                    xValue = 0;
                }else{
                    if(left){
                        xValue = 0.01f;
                    }else{
                        xValue = -0.01f;     
                    }
                }

            }
        }
        transform.Translate(xValue,0,-zValue);
    }
}
