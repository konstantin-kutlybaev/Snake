using UnityEngine;

public class Snake : MonoBehaviour
{
    public GameObject prefabBody;
    public GameObject prefabRottation1; 
    public GameObject prefabRottation2; 
    public float speed = 0.5f;
    float screenWidth = 0;
    float screenHiegth = 0;
    int headTurn = 0;
    float timer = 1;
    public bool eat = false;

    void Start()
    {
        screenHiegth = 25;
        screenWidth = Screen.width / (Screen.height / screenHiegth) - 0.7f;
    }

    void Update()
    {
        timer += Time.deltaTime;

        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Up();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Down();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right();
        }

        
        if (timer >= speed)
        {
            Move();
            timer = 0;
        }

    }

    void Move()
    {
        Head head = GetComponentInChildren<Head>();
        if (headTurn == 0 && head.transform.position.x + 1.5f < screenWidth)
        {

            Instantiate(prefabBody, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);

            head.transform.position = new Vector2(head.transform.position.x + 1.5f, head.transform.position.y);

            MoveBody();

        }
        if (headTurn == 90 && head.transform.position.y + 1.5f < screenHiegth)
        {

            Instantiate(prefabBody, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);

            head.transform.position = new Vector2(head.transform.position.x, head.transform.position.y + 1.5f);

            MoveBody();

        }
        if (headTurn == 180 && head.transform.position.x - 1.5f < screenHiegth)
        {

            Instantiate(prefabBody, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);

            head.transform.position = new Vector2(head.transform.position.x - 1.5f, head.transform.position.y);

            MoveBody();
        }
        if (headTurn == 270 && head.transform.position.y - 1.5f < screenHiegth)
        {

            Instantiate(prefabBody, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);

            head.transform.position = new Vector2(head.transform.position.x, head.transform.position.y - 1.5f);

            MoveBody();
        }
    }
    public void Reload()
    {
        headTurn = 0;
        Head head = GetComponentInChildren<Head>();
        head.transform.position = new Vector2(1.5f, 0);
        head.transform.rotation = Quaternion.Euler(0,0,0);

        Tail tail = GetComponentInChildren<Tail>();
        tail.transform.position = new Vector2(-3, 0);
        tail.transform.rotation = Quaternion.Euler(0, 0, 0);

        var body = GetComponentsInChildren<Body>();
        foreach (var bodySnake in body)
        {
            Destroy(bodySnake.gameObject);  
        }
        Instantiate(prefabBody, new Vector2(-1.5f,0), Quaternion.identity, transform);
        Instantiate(prefabBody, new Vector2(0, 0), Quaternion.identity, transform);
    }
    public void Eat()
    {
        eat = true;
    }
    void MoveBody()
    {
        if (!eat)
        {
            Body[] body = GetComponentsInChildren<Body>();

            Tail tail = GetComponentInChildren<Tail>();

            tail.transform.rotation = body[1].transform.rotation;
            tail.transform.position = body[0].transform.position;

            Destroy(body[0].gameObject);
        }
        else
            eat = false;
    }
    public void Right()
    {
        timer = 0;
        if (headTurn == 90 || headTurn == 270)
        {
            Head head = GetComponentInChildren<Head>();
            head.transform.rotation = Quaternion.Euler(0, 0, 0);

            if (headTurn == 90)
            {
                Instantiate(prefabRottation1, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            if (headTurn == 270)
            {
                Instantiate(prefabRottation2, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            headTurn = 0;

            head.transform.position = new Vector2(head.transform.position.x + 1.5f, head.transform.position.y);
            MoveBody();

        }
    }
    public void Left()
    {
        timer = 0;
        if (headTurn == 90 || headTurn == 270)
        {
            Head head = GetComponentInChildren<Head>();
            head.transform.rotation = Quaternion.Euler(0, 0, 180);

            if (headTurn == 270)
            {
                Instantiate(prefabRottation1, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            if (headTurn == 90)
            {
                Instantiate(prefabRottation2, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            headTurn = 180;

            head.transform.position = new Vector2(head.transform.position.x - 1.5f, head.transform.position.y);
            MoveBody();
        }  
    }
    public void Up()
    {
        timer = 0;
        if(headTurn == 0 || headTurn == 180)
        {
            Head head = GetComponentInChildren<Head>();
            head.transform.rotation = Quaternion.Euler(0, 0, 90);

            if(headTurn == 180)
            {
                Instantiate(prefabRottation1, head.transform.position, Quaternion.Euler(0,0, headTurn), transform);
            }
            if (headTurn == 0)
            {
                Instantiate(prefabRottation2, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            headTurn = 90;

            head.transform.position = new Vector2(head.transform.position.x, head.transform.position.y + 1.5f);
            MoveBody();

        }
    }
    public void Down()
    {
        timer = 0;
        if (headTurn == 0 || headTurn == 180)
        {
            Head head = GetComponentInChildren<Head>();
            head.transform.rotation = Quaternion.Euler(0, 0, 270);

            if (headTurn == 0)
            {
                Instantiate(prefabRottation1, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            if (headTurn == 180)
            {
                Instantiate(prefabRottation2, head.transform.position, Quaternion.Euler(0, 0, headTurn), transform);
            }
            headTurn = 270;

            head.transform.position = new Vector2(head.transform.position.x, head.transform.position.y - 1.5f);
            MoveBody();

        }
    }
}

