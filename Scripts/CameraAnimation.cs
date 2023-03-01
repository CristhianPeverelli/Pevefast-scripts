using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour{
    
    void Start(){
        GetComponent<Animator>().Play("CameraAnimation",  -1, 0f);
    }

}
