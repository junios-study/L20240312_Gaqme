using System.Data;

class Engine
{
    protected Engine()
    {
        gameObjects = new List<GameObject>();
        isRunning = true;
    }

    ~Engine()
    {

    }

    public static Engine? instance;

    public static Engine GetInstance()
    {
        if ( instance == null)
        {
            instance = new Engine();
        }

        return instance;
        //return instance ?? (instance = new Engine());
    }

    public List<GameObject> gameObjects;
    public bool isRunning;
    

    public void Init()
    {
        Input.Init();
    }

    public void Stop()
    {
        isRunning = false;
    }

    public void LoadScene(string sceneName)
    {
#if DEBUG
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        string Dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        string[] map = File.ReadAllLines(Dir + "/data/" + sceneName);
#else
        string Dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        string[] map = File.ReadAllLines(Dir + "/data/" + sceneName);
#endif

        //string[] map = File.ReadAllLines("./data/"+sceneName);

        for (int y = 0; y < map.Length; ++y)
        {
            for (int x = 0; x < map[y].Length; ++x)
            {
                if (map[y][x] == '*')
                {
                    GameObject newGameObject = Instantiate(new GameObject());
                    newGameObject.name = "Wall";
                    newGameObject.transform.x = x;
                    newGameObject.transform.y = y;
                    SpriteRenderer renderer = newGameObject.AddComponent<SpriteRenderer>();
                    renderer.Shape = '*';

                }
                else if (map[y][x] == ' ')
                {
                    GameObject newGameObject = Instantiate(new GameObject());
                    newGameObject.name = "Floor";
                    newGameObject.transform.x = x;
                    newGameObject.transform.y = y;
                    //SpriteRenderer renderer = newGameObject.AddComponent<SpriteRenderer>();
                    //renderer.Shape = ' ';

                }
                else if (map[y][x] == 'P')
                {
                    GameObject newGameObject = Instantiate(new GameObject());
                    newGameObject.name = "Player";
                    newGameObject.transform.x = x;
                    newGameObject.transform.y = y;
                    SpriteRenderer renderer = newGameObject.AddComponent<SpriteRenderer>();
                    renderer.Shape = 'P';
                }
                else if (map[y][x] == 'G')
                {
                    GameObject newGameObject = Instantiate(new GameObject());
                    newGameObject.name = "Goal";
                    newGameObject.transform.x = x;
                    newGameObject.transform.y = y;
                    SpriteRenderer renderer = newGameObject.AddComponent<SpriteRenderer>();
                    renderer.Shape = 'G';

                }
                else if (map[y][x] == 'M')
                {
                    GameObject newGameObject = Instantiate(new GameObject());
                    newGameObject.name = "Monster";
                    newGameObject.transform.x = x;
                    newGameObject.transform.y = y;
                    SpriteRenderer renderer = newGameObject.AddComponent<SpriteRenderer>();
                    renderer.Shape = 'M';
                }
            }
        }

        //gameObjects.Sort();

        //int WallCount = 0;
        //foreach (GameObject go in gameObjects)
        //{
        //    //reflection
        //    if (go.GetType() == typeof(Player))
        //    {
        //        WallCount++;
        //    }
        //}
        //Console.WriteLine(WallCount);
    }

    public void Run()
    {
        while (isRunning)
        {
            ProcessInput();
            Update();
            Render();
        } //frame
    }

    public void Term()
    {
        gameObjects.Clear();
    }

    //public GameObject Instantiate<T>() where T : GameObject
    //{
    //    return new T();
    //}

    public GameObject Instantiate(GameObject newGameObject)
    {
        gameObjects.Add(newGameObject);

        return newGameObject;
    }

    protected void ProcessInput()
    {
        Input.keyInfo = Console.ReadKey();
    }

    protected void Update()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            foreach(Component component in  gameObject.components)
            {
                component.Update();
            }
        }
    }

    protected void Render()
    {
        //for(int i = 0; i < gameObjects.Count; i++)
        //{
        //    gameObjects[i].Render();
        //}
        Console.Clear();
        foreach (GameObject gameObject in gameObjects)
        {
            Renderer? renderer = gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.Render();
            }
        }
    }

}


