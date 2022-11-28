using System;
namespace KitDB.TestModule
{
    class Module
    {
      public static void Main()
      {
            var Getter = new DataGetter();
            Getter.Run();
            Console.WriteLine(1 + Int32.Parse(Getter.GetData("id").ToString()));
      }
    }
}

