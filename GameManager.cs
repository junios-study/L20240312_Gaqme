class GameManager : Component
{
    public bool isGameOver;
    public bool isNextStage;

    protected Timer gameOverTimer;

    public GameManager()
    {
        isGameOver = false;
        isNextStage = false;
        gameOverTimer = new Timer(3000, ProcessGameOver);

    }

    public void ProcessGameOver()
    {
        Engine.GetInstance().Stop();
        Console.Clear();
        Console.WriteLine("GameOver");
    }

    public override void Update()
    {
        if (isGameOver)
        {
            gameOverTimer.Update();
        }

        if (isNextStage)
        {
            Console.Clear();
            Console.WriteLine("Congraturation.");
            Console.ReadKey();
            Engine.GetInstance().NextLoadScene("Level02.map");
        }
    }



}

