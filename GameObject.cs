class GameObject : IComparable<GameObject>
{
    public int x;
    public int y;

    public GameObject()
    {
        x = 0;
        y = 0;
        renderOrder = 0;
    }

    public GameObject(int newX, int newY)
    {
        x = newX;
        y = newY;
        renderOrder = 0;
    }

    ~GameObject()
    {

    }

    public virtual void Start()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void Render()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(shape);
    }

    public int CompareTo(GameObject? other)
    {
        if (other == null)
        {
            return 1;
        }

        if (renderOrder > other.renderOrder)
        {
            return 1;
        }
        else if (renderOrder == other.renderOrder)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public char shape;

    protected int renderOrder;

}

