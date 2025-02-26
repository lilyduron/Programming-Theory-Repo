using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    private float spawnRate = 2f;
    Vector3 spawnPos;
    float spawnPosX = 25;
    float spawnPosY = 1.1f;
    float spawnPosZ = -2f;
    float minSpawnInterval = 1.5f;  // Minimum spawn interval
    float maxSpawnInterval = 4f;  // Maximum spawn interval
    float randomInterval;

    public bool isGameActive;

    public GameObject moosePrefab;
    public GameObject foxPrefab;
    public GameObject stagPrefab;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       SelectedAnimal();
       isGameActive=true; 
       StartCoroutine(SpawnObjects());

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Spawn obstacles
    IEnumerator SpawnObjects ()
    {
        
         // If game is still active, spawn new object
        while (isGameActive)
        {
           yield return new WaitForSeconds(spawnRate);   
           spawnPos = new Vector3(spawnPosX,spawnPosY,spawnPosZ); 
           GetRandomInterval();

          if(isGameActive)
           {
              Instantiate(rockPrefab, spawnPos, rockPrefab.transform.rotation);  
           }
           
            
        }    
    }

    float GetRandomInterval()
    {
        randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval); 
        return randomInterval;
    }

    public void GameOver()
    {
       Debug.Log("Game Over!");
       isGameActive = false;
    }

    void SelectedAnimal()
    {
         string selectedAnimal = PlayerPrefs.GetString("SelectedAnimal");
         GameObject animalPrefab = null;

         switch (selectedAnimal)
         {
            case "Moose":
            animalPrefab = moosePrefab;
            break;
            case "Fox":
            animalPrefab = foxPrefab;
            break;
            case "Stag":
            animalPrefab = stagPrefab;
            break;
         }

         if(animalPrefab !=null)
         {
            Instantiate(animalPrefab, new Vector3(-21f,0,-2f), animalPrefab.transform.rotation);
         }
    }
}


