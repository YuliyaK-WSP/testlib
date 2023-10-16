using System;
using ds.test.impl;

namespace testlib 
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPlugin plugin = Plugins.GetPlugin("AdditionPlugin");
            if (plugin != null)
            {
                int result = plugin.Run(5, 3); 
                Console.WriteLine("Результат: " + result);
            }
        }
    }
}