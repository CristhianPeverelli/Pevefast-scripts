using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuScore : MonoBehaviour{

    [SerializeField] TMP_Text scoreTxt;
    [SerializeField] TMP_Text coinsTxt;
    
    void Start(){
        scoreTxt.text = PlayerPrefs.GetInt("MaxScore").ToString() + " HIGHSCORE";
        coinsTxt.text = PlayerPrefs.GetInt("CoinsCollected").ToString();
    }
    
}
