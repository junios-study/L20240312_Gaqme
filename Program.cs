class Program
{
    class Data : IComparable<Data>
    {
        public Data(int _a, int _c)
        {
            a = _a;
            c = _c;
        }
        public int a;
        public int c;

        //-1, 0, 1
        public int CompareTo(Data? other)
        {
            if (other == null)
            {
                return -1;
            }

            if (c > other.c)
            {
                return -1;
            }
            else if ( c == other.c) 
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }
    }


    static void Main(string[] args)
    {
        //Data d1 = new Data(1, 2);
        //Data d2 = new Data(3, 4);
        //List<Data> datas = new List<Data>();


        //Random random = new Random();
        //for (int i = 0; i < 10; i++)
        //{
        //    datas.Add(new Data(random.Next(0, 101), random.Next(0, 101)));
        //}

        //datas.Sort();

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(datas[i].a + "\t" + datas[i].c);
        //}

        Engine engine = new Engine();

        engine.Init();
        engine.LoadScene("level02.map");
        engine.Run();
        engine.Term();
    }
}

