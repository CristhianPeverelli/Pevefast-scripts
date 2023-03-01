using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scorer : MonoBehaviour{

    ScoreTxt scoreTxt;
    AudioSource audioSource;

    [SerializeField] Animator animator;
    [SerializeField] GameObject scoreContainer;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip powerUp2x;
    [SerializeField] AudioClip powerUpVoice;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] GameObject menuRiavvio;
    [SerializeField] GameObject commands;
    [SerializeField] GameObject optionButton;

    void Awake() {
        scoreTxt = scoreContainer.GetComponent<ScoreTxt>();
    }

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other) {
        switch(other.gameObject.tag){

            case "RailwayNoHit":
                audioSource.PlayOneShot(crash);
                crashParticle.Play();
                Invoke("ActiveRestartMenu",0.3f);
            break;

            case "Rampa":
                Debug.Log("Rampaaa");
                animator.SetBool("RampTouched",true);
                Invoke("RampEnded",1f);
            break;

            case "Pow2Points":
                Debug.Log("Doppio xp up");
                audioSource.PlayOneShot(powerUp2x);
                audioSource.PlayOneShot(powerUpVoice);
                PlayerPrefs.SetInt("ScoreMultiplier",2);
                Destroy(other.gameObject);
                Invoke("EndMultiplier",20f);
            break;
           
            default:
                //ToDo
            break;

        }
    }

    public void ActiveRestartMenu(){
        commands.SetActive(false);
        menuRiavvio.SetActive(true);
        optionButton.SetActive(false);
        Time.timeScale = 0;
        int actualScore = scoreTxt.getScore();
        int maxScore = PlayerPrefs.GetInt("MaxScore");
        if(maxScore < actualScore){
            PlayerPrefs.SetInt("MaxScore",actualScore);
        }
    }

    void LoadNextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void ReloadLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
        commands.SetActive(true);
        optionButton.SetActive(true);
    }

    private void RampEnded(){
        animator.SetBool("RampTouched",false);
    }

    private void EndMultiplier(){
        Debug.Log("Doppio xp down");
        PlayerPrefs.SetInt("ScoreMultiplier",1);
    }
}
