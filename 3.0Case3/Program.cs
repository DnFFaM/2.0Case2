using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _3._0Case3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Persons Name: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Persons Name: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age2 = Convert.ToInt32(Console.ReadLine());

            string Str = ime + prezime;
            System.IO.File.WriteAllText(@"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Names.txt", Str);

            string Age = Convert.ToString(age + age2); 
            System.IO.File.WriteAllText(@"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Passwords.txt", Age);

            Console.WriteLine($"{ime} + {prezime}");
            Console.WriteLine(Age);

        }
    }
}
