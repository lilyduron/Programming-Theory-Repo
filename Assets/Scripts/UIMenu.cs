using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int animal;
    public GameObject moosePrefab;
    public GameObject foxPrefab;
    public GameObject horsePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SelectAnimal); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectAnimal()
    {
       Debug.Log(button.gameObject.name + " was clicked");
      // gameManager.StartGame(animal);
       
       SceneManager.LoadScene("Main");

    }

    private void StartGame()
    {
       SceneManager.LoadScene("Main"); 
    }

    public void SelectMoose()
    {
        PlayerPrefs.SetString("SelectedAnimal", "Moose");
        StartGame();
    }

    public void SelectFox()
    {
        PlayerPrefs.SetString("SelectedAnimal", "Fox");
        StartGame();
    }

    public void SelectHorse()
    {
        PlayerPrefs.SetString("SelectedAnimal", "Horse");
        StartGame();
    }
}
