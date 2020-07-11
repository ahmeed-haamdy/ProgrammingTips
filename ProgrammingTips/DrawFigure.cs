using System;
using System.Collections.Generic;

namespace ProgrammingTips
{
    public class Snippets
    {
        public Snippets()
        {

        }

        public void DrawFigure()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public List<int> Fibonanci()
        {
            List<int> lst = new List<int>();



            return lst;
        }
    }
}
