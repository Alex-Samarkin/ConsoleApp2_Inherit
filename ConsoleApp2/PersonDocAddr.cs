// ConsoleApp2
// ConsoleApp2
// PersonDocAddr.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 3:54 22 11 2022

using System;

namespace ConsoleApp2
{
    public class PersonDocAddr : Person
    {
        public Address Address { get; set; } = new Address();
        public Document Document { get; set; } = new Document();

        public PersonDocAddr() : base()
        {
            Address = new Address();
            Document = new Document();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, " + "\n"+
                   $"Address: {Address}, " + "\n" +
                   $"Document: {Document}";
        }
    }
}