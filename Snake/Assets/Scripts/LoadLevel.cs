using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public string levelName;
    public Button loadLevel;

    private void Start()
    {
        loadLevel.onClick.AddListener(Level);
    }

    void Level()
    {
        SceneManager.LoadScene(levelName);
    }
}
