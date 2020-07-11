using System;

namespace ProgrammingTips
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //for (var i = 0; i < 1000; i++)
            //{
              //  Console.WriteLine(Convert.ToString(i, 2));
            //}

            var x = 10 + "5";

            Parent obj = new Child();

            Console.WriteLine(obj.GetName());

            //Snippets snippets = new Snippets();
            //snippets.DrawFigure();

        }

        public class Parent
        {
            public string GetName()
            {
                return "I am Parent";
            }
        }

        public class Child:Parent
        {
            public string GetName()
            {
                return "I am Child";
            }
        }
    }
}
