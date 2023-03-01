using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour{

    public GameObject[] characters;
    public int selectedCharacter;
   
    public void StartGame(){
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        Debug.Log("Ho caricato il carattere.");
    }

    public void changeCharacter(int index){
        Debug.Log("Sto caricando il carattere.");
        characters[selectedCharacter].SetActive(false);
        characters[index].SetActive(true);
        selectedCharacter = index;
    }

}
