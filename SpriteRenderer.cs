class SpriteRenderer : Renderer
{
    public SpriteRenderer()
    {
    }

    public char Shape;

    public override void Render()
    {
        Console.SetCursorPosition(transform.x, transform.y);
        Console.Write(Shape);
    }
}

