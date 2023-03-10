using System;
namespace uppgift4_4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annta");
            Console.WriteLine("3. Avsluta programmet");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("Skriv ett tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv ett tal till");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("svaret blir", tal1-tal2);
                Console.WriteLine(tal1 - tal2);
            }
            else if (a == "2")
            {
                Console.WriteLine("Skriv ett tal");
                double tal3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Skriv ett tal till");
                double tal4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("svaret blir", tal3 / tal4);
                Console.WriteLine(tal3 / tal4);
            }
            else if (a == "3")
            {
                Console.WriteLine("Hejdå");
            }
        }
    }
}