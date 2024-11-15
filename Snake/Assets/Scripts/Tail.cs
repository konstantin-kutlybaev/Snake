using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameController gameContr;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Saw")
        {
            gameContr.GameReload();
        }
    }
}
