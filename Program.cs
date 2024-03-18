using System.Reflection;

class Program
{
    //객체 한개 존재
    class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        private static Singleton? instance;

        public void Draw()
        {

        }
    }

    static void Main(string[] args)
    {
        Singleton.GetInstance().Draw();

        //        Engine engine = new Engine();

        //        engine.Init();
        //        engine.LoadScene("level01.map");
        //        engine.Run();
        //        engine.Term();
    }
}


