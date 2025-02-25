using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int animal;

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
}
