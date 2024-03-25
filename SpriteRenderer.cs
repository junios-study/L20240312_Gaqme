using SDL2;

public enum RenderOder
{
    None = 0,
    Floor = 100,
    Wall = 200,
    Goal = 300,
    Player = 400,
    Monster = 500,
}

class SpriteRenderer : Renderer
{

    public string textureName;

    public SpriteRenderer()
    {
        renderOrder = RenderOder.None;
        textureName = "";
    }
    public void Load(string _textureName)
    {
        textureName = _textureName;

        ResourceManager.Load(textureName);
    }

    public char Shape;
    public RenderOder renderOrder;

    public override void Render()
    {
        if (transform != null)
        {
            //Console.SetCursorPosition(transform.x, transform.y);
            //Console.Write(Shape);

            Engine myEngine = Engine.GetInstance();

            SDL.SDL_Rect destRect = new SDL.SDL_Rect();
            destRect.x = transform.x * 30;
            destRect.y = transform.y * 30;
            destRect.w = 30;
            destRect.h = 30;

            //unsafe //C, C++
            //{
                SDL.SDL_Rect rect = new SDL.SDL_Rect();
                rect.x = 0;
                rect.y = 0;
                uint format = 0;
                int access = 0;
                SDL.SDL_QueryTexture(ResourceManager.Load(textureName),
                    out format,
                    out access,
                    out rect.w,
                    out rect.h);

                SDL.SDL_RenderCopy(myEngine.myRenderer,
                    ResourceManager.Load(textureName),
                    ref rect,
                    ref destRect);
            //}
        }
    }
}
