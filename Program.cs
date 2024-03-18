using System.Reflection;

class Program
{
    class Parent
    {

    }

    class Child1 : Parent
    {
        public Child1() { }
        public Child1(int a) { }

        public int number;

        public int Gold { get; set; }
    }

    class Child2 : Parent
    {
    }

    static void Main(string[] args)
    {
        //GetConstructors()
        //GetFields()
        //GetInterfaces()
        //GetMembers()
        //GetMethods()
        //GetProperties()
        Child1 c = new Child1();

        FieldInfo[] datas = c.GetType().GetFields();
        foreach (FieldInfo d in datas)
        {
           Console.WriteLine(d.Name);
        }

        PropertyInfo[] datas2 = c.GetType().GetProperties();
        foreach (PropertyInfo d in datas2)
        {
            Console.WriteLine(d.Name);
        }


        //        Engine engine = new Engine();

        //        engine.Init();
        //        engine.LoadScene("level01.map");
        ////        engine.Run();
        //        engine.Term();
    }
}


