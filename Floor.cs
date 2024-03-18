


class Floor : GameObject
{
    public Floor()
    {
        shape = ' ';
        layerOrder = 10;
    }

    public Floor(int newX, int newY)
    {
        shape = ' ';

        x = newX;
        y = newY;
        layerOrder = 10;
    }

    ~Floor()
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

