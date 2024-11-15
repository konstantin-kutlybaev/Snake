using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public GameController gameController;
    int life = 3;

    public void DownLife()
    {
        life--;
        GetComponent<TMP_Text>().text = life.ToString();

        if(life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
