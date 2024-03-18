using System.Reflection;

class Program
{
    class Parent
    {
        public virtual void Pay()
        {
            Console.WriteLine("지불한다.");
        }
    }

    class Child1 : Parent
    {
        public override void Pay()
        {
            Console.WriteLine("대신 지불한다.");
        }
    }

    class Child2 : Parent
    {
        public void Run()
        {
            Console.WriteLine("도망간다.");
        }
    }

    static void Main(string[] args)
    {
        List<Parent> lists = new List<Parent>();
        lists.Add(new Child1());
        lists.Add(new Parent());
        lists.Add(new Child2());

        for(int i = 0; i < lists.Count; i++) 
        {
            //lists[i].Pay();
            //Reflection
            //if( lists[i].GetType() == typeof(Child2) )
            //{
            //    ((Child2)lists[i]).Run();
            //}
            //다운캐스팅
            Child2 child2 = lists[i] as Child2;
            if (child2 != null)
            {
                child2.Run();
                ((Parent)child2).Pay();
            }
            else
            {
                Console.WriteLine("Child2가 아님");
            }

        }

        //        Engine engine = new Engine();

        //        engine.Init();
        //        engine.LoadScene("level01.map");
        ////        engine.Run();
        //        engine.Term();
    }
}


