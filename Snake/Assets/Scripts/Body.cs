using UnityEngine;

public class Body : MonoBehaviour
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
