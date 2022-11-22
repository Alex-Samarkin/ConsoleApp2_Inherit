using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDocAddr person = new PersonDocAddr();
            person.FirstName = "Иванов";
            person.Address.Street = "пер. Комиссаровский";
            person.Document.Series = "12*35";
            // output and waiting for Enter key
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
