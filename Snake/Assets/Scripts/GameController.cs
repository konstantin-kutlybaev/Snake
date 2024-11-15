using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Snake snake;
    public Fruts fruts;
    public Score score;
    public Life life;
    public string levelName;
    public TMP_Text lose;
    public TMP_Text win;
    public TMP_Text text;
    private float timer = 0;
    private bool activeText = false;

   
    public void GameReload(bool isfail = true)
    {
        snake.Reload();
        fruts.NewFruit();
        score.ReloadScore();
        life.DownLife();
        

        if (isfail)
        {
            text = lose;
            text.gameObject.SetActive(true);
            timer = 0;
            activeText = true;
        }
        else
        {
            text = win;
            text.gameObject.SetActive(true);
            timer = 0;
            activeText = true;
            SceneManager.LoadScene(levelName);
        }
    }



    private void Update()
    {
        if (activeText && timer > 3)
        {
            text.gameObject.SetActive(false);
            activeText = false;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
