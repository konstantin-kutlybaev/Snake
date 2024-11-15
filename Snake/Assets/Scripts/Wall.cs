using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject prefabBox;
    float screenWidth = 0;
    float screenHiegth = 0;
    
    void Start()
    {
        screenHiegth = 25;
        screenWidth = Screen.width / (Screen.height / screenHiegth) - 0.7f;

        int x = (int)(screenWidth / 1.5f);
        int y = (int)(screenHiegth / 1.5f);

        for(int i = 0; i <= x; i++)
        {
            Instantiate(prefabBox, new Vector2(i * 1.5f, y * 1.5f), Quaternion.identity,transform);
            Instantiate(prefabBox, new Vector2(-i * 1.5f, y * 1.5f), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector2(i * 1.5f, -y * 1.5f), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector2(-i * 1.5f, -y * 1.5f), Quaternion.identity, transform);
        }
        for (int i = 0; i < y; i++)
        {
            Instantiate(prefabBox, new Vector2(x * 1.5f, i * 1.5f), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector2(-x * 1.5f, i * 1.5f), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector2(x * 1.5f, -i * 1.5f), Quaternion.identity, transform);
            Instantiate(prefabBox, new Vector2(-x * 1.5f, -i * 1.5f), Quaternion.identity, transform);
        }
    }
}
