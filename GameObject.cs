﻿class GameObject : IComparable<GameObject>
{
    public int x;
    public int y;

    public GameObject()
    {
        x = 0;
        y = 0;
        layerOrder = 0;
    }

    public GameObject(int newX, int newY)
    {
        x = newX;
        y = newY;
        layerOrder = 0;
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

        if (layerOrder > other.layerOrder)
        {
            return 1;
        }
        else if (layerOrder == other.layerOrder)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public char shape;

    protected int layerOrder;

}

