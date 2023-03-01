using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour{

    public int coinsOnScreen;
    public TMP_Text coinsCollected;

    [SerializeField] AudioClip picked;

    AudioSource audioSource;

    void Start(){
        coinsOnScreen = 0;
        coinsCollected.text = " " + coinsOnScreen.ToString();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Coin"){
            coinsOnScreen++;
            coinsCollected.text = " " + coinsOnScreen.ToString();
            audioSource.PlayOneShot(picked);
            Destroy(other.gameObject);
            updateCoins();
        }
    }

    void updateCoins(){
        int actualCoins = PlayerPrefs.GetInt("CoinsCollected");
        actualCoins += 1;
        PlayerPrefs.SetInt("CoinsCollected", actualCoins);
    }

    void Update(){
        
    }
}
