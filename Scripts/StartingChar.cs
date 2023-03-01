using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingChar : MonoBehaviour{

    public GameObject[] characters;
   
    void Start(){
        for(int i = 0; i < characters.Length; i++){
            characters[i].SetActive(false);
        }
        int index = PlayerPrefs.GetInt("selectedCharacter");
        Debug.Log("Stai guidando la macchina "+index);
        if(index <= 0){ 
            characters[0].SetActive(true);
        }else{
            characters[index-1].SetActive(true);
        }
    }

}
