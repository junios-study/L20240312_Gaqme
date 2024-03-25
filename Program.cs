using SDL2;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //List<int> gameObjects = new List<int> { 20, 17, 3, 5, 2, 5, 18, 16, 1, 9 };

        //for (int i = 0; i < gameObjects.Count; i++)
        //{
        //    for(int j = i+1; j < gameObjects.Count; j++)
        //    {
        //        if (gameObjects[i] > gameObjects[j])
        //        {
        //            int temp = gameObjects[i];
        //            gameObjects[i] = gameObjects[j];
        //            gameObjects[j] = temp;
        //        }
        //    }
        //}

        //foreach(var i in gameObjects)
        //{
        //    Console.WriteLine(i);
        //}
        string dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        Engine engine = Engine.GetInstance();

        engine.Init();
        SDL_mixer.Mix_OpenAudio(44100, SDL_mixer.MIX_DEFAULT_FORMAT, 2, 4096);
        IntPtr bgm = SDL_mixer.Mix_LoadMUS(dir +  "/data/bgm.mp3");
        //SDL_mixer.Mix_PlayMusic(bgm, 1);
        SDL_mixer.Mix_Volume(-1, 10);

        engine.LoadScene("level01.map");
        engine.Run();
        engine.Term();

        SDL_mixer.Mix_FreeMusic(bgm);
        SDL_mixer.Mix_CloseAudio();
    }
}


