using SDL2;

class ResourceManager
{
    protected static Dictionary<string, IntPtr> Database =  new Dictionary<string, IntPtr>();

    public static IntPtr Load(string _filename)
    {
        if ( !Database.ContainsKey(_filename) )
        {
            string Dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            IntPtr mySurface = SDL.SDL_LoadBMP(Dir + "/data/" + _filename);
            IntPtr myTexture = SDL.SDL_CreateTextureFromSurface(Engine.GetInstance().myRenderer, mySurface);

            Database[_filename] = myTexture;

            SDL.SDL_FreeSurface(mySurface);
        }
        return Database[_filename];
    }

}

