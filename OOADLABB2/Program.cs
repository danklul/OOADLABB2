using System;

namespace OOADLABB2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press a key");
            Console.ReadKey();
            IViewer viewer = new ConsoleViewer(new AstronautServices());
            viewer.Load();
        }
    }
}