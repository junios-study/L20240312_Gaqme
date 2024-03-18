class SpriteRenderer : Renderer
{
    public SpriteRenderer()
    {
    }

    public char Shape;

    public override void Render()
    {
        if (transform != null)
        {
            Console.SetCursorPosition(transform.x, transform.y);
            Console.Write(Shape);
        }
    }
}

