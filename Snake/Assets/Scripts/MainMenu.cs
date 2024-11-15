using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button exit;

    
    void Start()
    {
        level1.onClick.AddListener(StartLevel1);
        level2.onClick.AddListener(StartLevel2);
        exit.onClick.AddListener(ExitGame);
    }

    void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    void StartLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    void ExitGame()
    {
        Application.Quit();
    }
}
