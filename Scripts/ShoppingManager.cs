using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShoppingManager : MonoBehaviour{

    private bool hasBeenPurchased;
    public int indexC;
    public int cost;
    [SerializeField] TMP_Text coinsTxt;


    private void Start() {
        PlayerPrefs.SetString("purchaseLog","");
        PlayerPrefs.SetInt("CoinsCollected",100000);
    }
    //DA SISTEMARE

    public void tryPurchase(){  
        hasBeenPurchased = PlayerPrefs.GetString("purchaseLog").Contains(indexC+"-"); 
        Debug.Log(PlayerPrefs.GetString("purchaseLog"));
        int money = PlayerPrefs.GetInt("CoinsCollected");
        if(!hasBeenPurchased && money >= cost){
            Debug.Log("Hai acquistato la macchina "+indexC);
            money = money - cost;
            PlayerPrefs.SetInt("CoinsCollected",money);
            PlayerPrefs.SetString("purchaseLog",(PlayerPrefs.GetString("purchaseLog")+indexC+"-"));
            PlayerPrefs.SetInt("selectedCharacter",indexC);
            coinsTxt.text = money.ToString();
        }else{
            Debug.Log("Non hai abbastanza soldi.");
        }
    }

}
