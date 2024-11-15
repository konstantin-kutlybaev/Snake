using UnityEngine;

public class Fruit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GetComponentInParent<Fruts>().NewFruit();
    }
}
