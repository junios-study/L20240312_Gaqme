


class Goal : GameObject
{
    public Goal()
    {
        shape = 'G';
        layerOrder = 100;
    }

    public Goal(int newX, int newY)
    {
        shape = 'G';

        x = newX;
        y = newY;
        layerOrder = 100;
    }

    ~Goal()
    {

    }

    public override void Start()
    {

    }

    public override void Update()
    {

    }

    public override void Render()
    {
        base.Render();
    }
}

