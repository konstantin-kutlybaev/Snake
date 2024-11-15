using UnityEngine;

public class Fruts : MonoBehaviour
{
    public GameObject apple;
    public GameObject pineapple;
    public GameObject pear;
    int height = 0;
    int width = 0;
    int sizeHeight = 25;
    float timer = 0;
    float speed = 5;
    void Start()
    {
        height = (int)(sizeHeight / 1.5f) - 1;
        width = (int)((Screen.width / (Screen.height / sizeHeight) - 0.5f) / 1.5f) - 1;
    }

    
    void Update()
    {
        if (timer * speed < 0)
        {
            if(GetComponentInChildren<Fruit>() != null)
            {
                Destroy(GetComponentInChildren<Fruit>().gameObject);
            }

            GenerateFrute();
            timer = height + width;
        }
        timer -= Time.deltaTime;
    }
    public void NewFruit()
    {
        timer = -1;
    }
    void GenerateFrute()
    {
        int random = Random.Range(0, 3);
        GameObject fruit;

        switch (random)
        {
            case 0:
                fruit = apple; 
                break;
            case 1:
                fruit = pineapple;
                break;
            default:
                fruit = pear;
                break;

        }
        int[] array = { -1, 1 };
        int x = Random.Range(0, width) * array[Random.Range(0,2)];
        int y = Random.Range(0, height) * array[Random.Range(0, 2)];

        Instantiate(fruit, new Vector2(x * 1.5f, y * 1.5f), Quaternion.identity, transform);
    }
}
