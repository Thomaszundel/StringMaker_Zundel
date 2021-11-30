using System;

namespace StringMaker_Zundel
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager managerS = new StringManager();

            Console.WriteLine(managerS.Reverse("Sunbeam Tiger"));
            Console.WriteLine(managerS.ToString());
            Console.WriteLine(managerS.Reverse("Sunbeam Tiger",true));
            Console.WriteLine(managerS.Equals("Sunbeam Tiger"));
            Console.WriteLine(managerS.Symmetric("ABBA"));
            Console.WriteLine(managerS.Symmetric("ABA"));
            Console.WriteLine(managerS.Symmetric("ABba"));
            
            

        }
    }
}
