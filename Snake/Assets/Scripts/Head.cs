using UnityEngine;

public class Head : MonoBehaviour
{
    public Score score;
    public Snake snake;
    public GameController gameContr;
    public AudioSource bite;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fruit")
        {
            snake.Eat();
            score.UpScore();
            bite.Play();

        }
        else
        {
            gameContr.GameReload();
        }
    }
}
