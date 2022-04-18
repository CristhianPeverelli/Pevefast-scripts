using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    public float score;

    void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    void Update(){
        score = score + 10 * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "CarUnhitted"){
            other.gameObject.tag = "CarHitted";
            Debug.Log("Score: "+score);
            score = 0f;
        }
    }
}
