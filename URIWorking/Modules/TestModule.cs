using System;
namespace KitDB.TestModule
{
    class Module
    {
        public static void Main()
        {
            //Makes an instance of Datagetter
            var Getter = new DataGetter();
            //Runs the getter to access the Database
            Getter.Run();
            Console.WriteLine("Enter a Key");
            //Gets User input
            var pword = Console.ReadLine();
            //Accesses the database and prints the associated value
            Console.WriteLine(Getter.GetData(pword));
            //A closing input to keep the prompt from closing
            Console.ReadLine();
            
        }
    }
}

