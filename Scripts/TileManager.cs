using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour{
    
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    [SerializeField] public float tileLength = 200;
    public int tilesOnScreen = 3;
    private int lastTile;

    private List<GameObject> activeTiles = new List<GameObject>(); 

    public Transform playerTransform;

    void Start(){
        SpawnTile(0);
        for(int i=0; i < tilesOnScreen; i++){
            int tileChoose = Random.Range(1,tilePrefabs.Length);
            if(tileChoose == lastTile){
                do{
                    tileChoose = Random.Range(1,tilePrefabs.Length);
                }while(tileChoose == lastTile);
            }
            SpawnTile(tileChoose);
        }
    }

    void Update(){
    
        if (playerTransform.position.z - tileLength > zSpawn - (tilesOnScreen * tileLength)){
            int tileChoose = Random.Range(1,tilePrefabs.Length);
            if(tileChoose == lastTile){
                do{
                    tileChoose = Random.Range(1,tilePrefabs.Length);
                }while(tileChoose == lastTile);
            }
            SpawnTile(tileChoose);
            lastTile = tileChoose;
            DeleteTile();

        }
    }

    public void SpawnTile(int tileIndex){
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn , transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }

    private void DeleteTile(){
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
