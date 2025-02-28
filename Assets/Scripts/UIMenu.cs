using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
  
    public GameObject moosePrefab;
    public GameObject foxPrefab;
    public GameObject stagPrefab;

    
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

    public void SelectStag()
    {
        PlayerPrefs.SetString("SelectedAnimal", "Stag");
        StartGame();
    }
}
