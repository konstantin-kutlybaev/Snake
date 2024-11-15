using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public GameController gameController;
    int score = 0;
    int sizeHeight = 25;
    int maxScore;

    private void Start()
    {
       int height = (int)(sizeHeight / 1.5f) - 1;
       int width = (int)((Screen.width / (Screen.height / sizeHeight) - 0.5f) / 1.5f) - 1;

        //maxScore = height * width - 4;
        maxScore = 5;
    }

    public void UpScore()
    {
        score++;
        GetComponent<TMP_Text>().text = score.ToString();

        if(score == maxScore )
        {
            gameController.GameReload(false);
        }
    }

    public void ReloadScore()
    {
        score = 0;
        GetComponent<TMP_Text>().text = score.ToString();
    }
}
