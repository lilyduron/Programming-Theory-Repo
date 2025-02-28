using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    private float spawnRate = 2f;
    Vector3 spawnPos;
    float spawnPosX = 25;
    float spawnPosY = 1.1f;
    float spawnPosZ = -2;
    float minSpawnInterval = 1.5f;  // Minimum spawn interval
    float maxSpawnInterval = 4f;  // Maximum spawn interval
    float randomInterval;

    public bool isGameActive;

    public GameObject moosePrefab;
    public GameObject foxPrefab;
    public GameObject stagPrefab;
    public GameObject GameOverText;
    

    
    void Start()
    {
       SelectedAnimal();   //ABSTRACTION
       isGameActive=true; 
       StartCoroutine(SpawnObjects());   
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
       GameOverText.SetActive(true);
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
            // Instantiate the animal prefab
            GameObject animalInstance = Instantiate(animalPrefab, new Vector3(0, 0, 0), animalPrefab.transform.rotation);

            // Access the Animal component of the instantiated animal prefab
            Animal animal = animalInstance.GetComponent<Animal>();

        if (animal != null)
            {
               // Set the position using the values from the Animal class
               animalInstance.transform.position = new Vector3(animal.PosX, animal.PosY, animal.PosZ);
            }
            
         }  
    }

    public void Restart()
    {
       SceneManager.LoadScene(0);
    }
}


