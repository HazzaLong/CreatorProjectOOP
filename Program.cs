using System;

namespace FirstOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer() };

            foreach(var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
        }
    }
}
